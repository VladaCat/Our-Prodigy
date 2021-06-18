using System;

using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace base64Research
{
    
    public partial class frmBase64 : Form
    {
        public byte[] srcArray = new byte[5]  {1, 255, 36, 45, 5};
        public byte[] dstArray = new byte[] { };

        Stream srcStream;
        Stream dstStream;

        public frmBase64()
        {
            InitializeComponent();
        }

        private void frmBase64_Load(object sender, EventArgs e)
        {

        }

        private string ArrayToString(byte[] arr)

        {
            string tmpStr = "";
            foreach (var b in arr)
            {
                tmpStr += b.ToString()+" ";
            }

            return tmpStr;
        }

        private void btnShowSrcArray_Click(object sender, EventArgs e)
        {
            txtSrcArray.Text = ArrayToString(srcArray);
        }

        private void btnDstArray_Click(object sender, EventArgs e)
        {
            txtDstArray.Text = ArrayToString(dstArray);
        }

        private void btnToBase64_Click(object sender, EventArgs e)
        {
            txtBase64.Text = Convert.ToBase64String(srcArray);
        }

        private void btnFromBase64_Click(object sender, EventArgs e)
        {
            dstArray = Convert.FromBase64String(txtBase64.Text);
        }

        private void txtCompareArrays_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AreEqualsArrays(srcArray, dstArray).ToString());
        }

        private bool AreEqualsArrays(byte[] a, byte[] b)
        {
            if (a.Length!=b.Length)
            {
                return false;
            }
            else
            {
                for (int i=0; i<=a.GetUpperBound(0); i++)
                {
                    if (a[i]!=b[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        private void btnSavePictureToStream_Click(object sender, EventArgs e)
        {
            srcStream = new MemoryStream();
            EncoderParameters ec = new EncoderParameters();
            pbSrc.Image.Save(srcStream, ImageFormat.Png);

            

            srcStream.Position = 0;
            srcArray = new byte[srcStream.Length];
            srcStream.Read(srcArray, 0, Convert.ToInt32(srcStream.Length));

            //srcArray = ((MemoryStream)srcStream).ToArray();


        }

        private void btnRestorePicture_Click(object sender, EventArgs e)
        {
            dstStream = new MemoryStream(dstArray);
            //MessageBox.Show(dstStream.Length.ToString());

            
            //MessageBox.Show(dstStream.CanRead.ToString());
            pbDst.Image = Image.FromStream(dstStream);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            srcStream.Position = 0;
            pbDst.Image = Image.FromStream(srcStream);
        }

        private void btnDstToFile_Click(object sender, EventArgs e)
        {
            dstStream = new MemoryStream(dstArray);
            //MessageBox.Show(dstStream.Length.ToString());

            dstStream.Position = 0;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            dstStream.CopyTo(fs);
            fs.Flush();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            srcStream.Position = 0;
            srcStream.CopyTo(fs);
            fs.Flush();
            fs.Close();
        }
    }
}
