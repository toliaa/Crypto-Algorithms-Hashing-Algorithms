using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncMethodsApp
{
    public partial class AsyncMethods : Form
    {
        private CancellationTokenSource ctsREDOC;
        private CancellationTokenSource ctsSHA;
        private CancellationTokenSource ctsLUC;

        public AsyncMethods()
        {
            InitializeComponent();
        }

        private async void btnRunREDOC_Click(object sender, EventArgs e)
        {
            ctsREDOC = new CancellationTokenSource();
            try
            {
                string input = textBoxInput.Text;
                textBoxREDOC.Text = await RunREDOC(input, ctsREDOC.Token);
            }
            catch (OperationCanceledException)
            {
                textBoxREDOC.Text = "REDOC cancelled";
            }
        }

        private void btnStopREDOC_Click(object sender, EventArgs e)
        {
            ctsREDOC?.Cancel();
        }

        private async void btnRunSHA_Click(object sender, EventArgs e)
        {
            ctsSHA = new CancellationTokenSource();
            try
            {
                string input = textBoxInput.Text;
                textBoxSHA.Text = await RunSHA(input, ctsSHA.Token);
            }
            catch (OperationCanceledException)
            {
                textBoxSHA.Text = "SHA cancelled";
            }
        }

        private void btnStopSHA_Click(object sender, EventArgs e)
        {
            ctsSHA?.Cancel();
        }

        private async void btnRunLUC_Click(object sender, EventArgs e)
        {
            ctsLUC = new CancellationTokenSource();
            try
            {
                string input = textBoxInput.Text;
                textBoxLUC.Text = await RunLUC(input, ctsLUC.Token);
            }
            catch (OperationCanceledException)
            {
                textBoxLUC.Text = "LUC cancelled";
            }
        }

        private void btnStopLUC_Click(object sender, EventArgs e)
        {
            ctsLUC?.Cancel();
        }

        private async void btnRunAll_Click(object sender, EventArgs e)
        {
            ctsREDOC = new CancellationTokenSource();
            ctsSHA = new CancellationTokenSource();
            ctsLUC = new CancellationTokenSource();

            string input = textBoxInput.Text;

            var redocTask = RunREDOC(input, ctsREDOC.Token);
            var shaTask = RunSHA(input, ctsSHA.Token);
            var lucTask = RunLUC(input, ctsLUC.Token);

            try
            {
                textBoxREDOC.Text = await redocTask;
                textBoxSHA.Text = await shaTask;
                textBoxLUC.Text = await lucTask;
            }
            catch (OperationCanceledException)
            {
                textBoxREDOC.Text = redocTask.IsCanceled ? "REDOC cancelled" : textBoxREDOC.Text;
                textBoxSHA.Text = shaTask.IsCanceled ? "SHA cancelled" : textBoxSHA.Text;
                textBoxLUC.Text = lucTask.IsCanceled ? "LUC cancelled" : textBoxLUC.Text;
            }
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            ctsREDOC?.Cancel();
            ctsSHA?.Cancel();
            ctsLUC?.Cancel();
        }

        private async Task<string> RunREDOC(string input, CancellationToken token)
        {
            await Task.Delay(2000, token); // Імітація тривалої операції
            return EncryptREDOC(input);
        }

        private async Task<string> RunSHA(string input, CancellationToken token)
        {
            await Task.Delay(3000, token); // Імітація тривалої операції
            return ComputeSHA256(input);
        }

        private async Task<string> RunLUC(string input, CancellationToken token)
        {
            await Task.Delay(1000, token); // Імітація тривалої операції
            return EncryptLUC(input);
        }

        private string EncryptREDOC(string input)
        {
            // Імітація алгоритму шифрування REDOC
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(bytes);
        }

        private string ComputeSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder result = new StringBuilder();
                foreach (byte b in bytes)
                {
                    result.Append(b.ToString("x2"));
                }
                return result.ToString();
            }
        }

        private string EncryptLUC(string input)
        {
            // Імітація алгоритму шифрування LUC
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(bytes.Reverse().ToArray());
        }
    }
}
