using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using PostLite.Model;
using System.Data;

namespace PostLite
{
    public partial class MainForm : Form
    {
        AutoCompleteStringCollection postHeaderKeys = new AutoCompleteStringCollection();
        AutoCompleteStringCollection postHeaderValues = new AutoCompleteStringCollection();
        PostRequest PostRequestProp = new PostRequest();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DefaultValues();

            postHeaderKeys.AddRange(Properties.Settings.Default.PostHeaderKeyList.Split(',').Select(p => p.Trim()).ToArray());
            postHeaderValues.AddRange(Properties.Settings.Default.PostHeaderValueList.Split(',').Select(p => p.Trim()).ToArray());
        }

        private void DefaultValues()
        {
            lblTime.Text = string.Empty;
            lblStatus.Text = string.Empty;
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.PostRequest))
                return;

            PostRequestProp = Util.Deserialize<PostRequest>(Properties.Settings.Default.PostRequest);
            tbUrl.Text = PostRequestProp.URL;
            rtbRequest.Text = PostRequestProp.Body;

            foreach(var header in PostRequestProp.Header)
            {
                dgvHeader.Rows.Add(header.HeaderKey, header.HeaderValue);
            }

            tabInput.TabPages[1].Text = string.Format("Headers ({0})", PostRequestProp.Header.Count);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUrl.Text))
            {
                MessageBox.Show("URL cannot be empty", "Error");
                return;
            }

            PostRequestProp.URL = tbUrl.Text;
            PostRequestProp.Body = rtbRequest.Text;
            PostRequestProp.Header = Util.ParseHeaderAndRemoveInvalid(dgvHeader);
            tabInput.TabPages[1].Text = string.Format("Headers ({0})", PostRequestProp.Header.Count);
            bgw.RunWorkerAsync();
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            var postResponse = Util.WebClientPost(PostRequestProp);

            Invoke((Action)(() => {
                tbResponse.Text = postResponse.ResponseBody;
                lblTime.Text = postResponse.Time;
                lblStatus.Text = postResponse.StatusCode;
                lblStatus.ForeColor = postResponse.StatusCode == "OK"? System.Drawing.Color.Green: System.Drawing.Color.Red;
            }));
            
            Properties.Settings.Default.PostRequest = Util.Serialize(PostRequestProp);
            Properties.Settings.Default.Save();
        }

        

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvHeader.CurrentCell.ColumnIndex == 0)
            {
                var tbPostHeaderKey = e.Control as TextBox;

                if (tbPostHeaderKey != null)
                {
                    tbPostHeaderKey.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tbPostHeaderKey.AutoCompleteCustomSource = postHeaderKeys;
                    tbPostHeaderKey.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }else if (dgvHeader.CurrentCell.ColumnIndex == 1)
            {
                var tbPostHeaderValue = e.Control as TextBox;

                if (tbPostHeaderValue != null)
                {
                    tbPostHeaderValue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tbPostHeaderValue.AutoCompleteCustomSource = postHeaderValues;
                    tbPostHeaderValue.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
        }

        private void dgvHeader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if(!dgvHeader.Rows[e.RowIndex].IsNewRow)
                    dgvHeader.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
