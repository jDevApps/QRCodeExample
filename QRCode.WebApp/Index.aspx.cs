using MessagingToolkit.QRCode.Codec;
using System;
using System.Drawing;
using System.IO;

namespace QRCode.WebApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void buttonGenerate_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap img = encoder.Encode(textCode.Text);
            System.Drawing.Image QR = (System.Drawing.Image)img;

            using (MemoryStream ms = new MemoryStream())
            {
                QR.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                imgQR.ImageUrl = $"data:image/gif;base64, {Convert.ToBase64String(imageBytes)}";
                imgQR.Height = 200;
                imgQR.Width = 200;
            }
        }
    }
}