
using QRCoder.Core;
using System.Drawing.Imaging;
using System.Drawing;
using static QRCoder.Core.PayloadGenerator;


Url generator = new Url("https://github.com/marhamatabadi");
string payload = generator.ToString();
// Generate the QR code
QRCodeGenerator qrGenerator = new QRCodeGenerator();
QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
QRCode qrCode = new QRCode(qrCodeData);
Bitmap qrCodeImage = qrCode.GetGraphic(20);


// Specify the folder path to save the QR code image
string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
string projectPath = appDirectory.Substring(0, appDirectory.IndexOf("\\bin"));
string folderPath = $"{projectPath}\\OUTPUT";

// Create the folder if it doesn't exist
if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

// Save the QR code as a PNG image file inside the specified folder
string fileName = Path.Combine(folderPath,  DateTime.Now.Ticks.ToString()+ "_" + "QRCode.png");
qrCodeImage.Save(fileName, ImageFormat.Png);
Console.ReadLine();
