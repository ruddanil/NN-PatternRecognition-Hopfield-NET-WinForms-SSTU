using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;

namespace Hopfield
{
    public partial class Form1 : Form
    {
        private Graphics _formGraphics;
        private bool _drawing;
        private readonly DrawField _drawField = new DrawField();
        private string[] _bitmapFilePaths = new string[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void NoiseAndLoad(int pictureIndex)
        {
            int noise = trackBarNoise.Value;
            Bitmap noised = BitmapParser.Noise(new Bitmap(_bitmapFilePaths[pictureIndex]), noise).ToBitmap();
            Bitmap scaledNoised = BitmapParser.Scale(noised, DrawField.CellSize);
            picNoised.Image = scaledNoised;
        }

        private void BtnEducate_Click(object sender, EventArgs e)
        {
            btnRecognizeDrawn.Enabled = true;
            btnRecognizeNoised.Enabled = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_drawing) return;
            if (!CursorIsInsideDrawField(e.X, e.Y)) return;
            int xOffset = e.X - DrawField.Left;
            int yOffset = e.Y - DrawField.Top;
            int rowIndex = yOffset / DrawField.CellSize;
            int columnIndex = xOffset / DrawField.CellSize;
            if (rowIndex >= DrawField.CellsCount) rowIndex = DrawField.CellsCount - 1;
            if (columnIndex >= DrawField.CellsCount) columnIndex = DrawField.CellsCount - 1;
            _drawField[rowIndex, columnIndex] = +1;
            _formGraphics.FillRectangle(Brushes.Black, DrawField.Left + DrawField.CellSize * columnIndex,
                DrawField.Top + DrawField.CellSize * rowIndex, DrawField.CellSize, DrawField.CellSize);
        }

        private static bool CursorIsInsideDrawField(int x, int y)
        {
            return x >= DrawField.Left && x <= DrawField.Left + DrawField.Size &&
                   y >= DrawField.Top && y <= DrawField.Top + DrawField.Size;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, DrawField.Left, DrawField.Top,
                DrawField.Size, DrawField.Size);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _formGraphics = CreateGraphics();
            _formGraphics.DrawRectangle(Pens.Violet, 0, 0, DrawField.Size, DrawField.Size);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _drawing = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _drawing = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _drawField.Clear();
            _formGraphics.FillRectangle(Brushes.White, DrawField.Left, DrawField.Top,
                DrawField.Size, DrawField.Size);
        }

        private void BtnSelect1_Click(object sender, EventArgs e)
        {
            LoadImage(picSample1);
        }

        private void BtnSelect2_Click(object sender, EventArgs e)
        {
            LoadImage(picSample2);
        }

        private void BtnSelect3_Click(object sender, EventArgs e)
        {
            LoadImage(picSample3);
        }

        private void BtnSelect4_Click(object sender, EventArgs e)
        {
            LoadImage(picSample4);
        }

        private void BtnSelect5_Click(object sender, EventArgs e)
        {
            LoadImage(picSample5);
        }

        private void LoadImage(PictureBox pictureBox)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() != DialogResult.OK) return;
                string filePath = ofd.FileName;
                int index = int.Parse(pictureBox.Name.Substring(pictureBox.Name.Length - 1)) - 1;
                _bitmapFilePaths[index] = filePath;
                pictureBox.Image = BitmapParser.Scale(new Bitmap(filePath), DrawField.CellSize);
            }
        }

        private int GetCheckedRadioButtonIndex()
        {
            RadioButton checkedRadioButton = Controls.OfType<RadioButton>().First(r => r.Checked);
            return int.Parse(checkedRadioButton.Text) - 1;
        }

        private void Radio1_CheckedChanged(object sender, EventArgs e)
        {
            NoiseAndLoad(GetCheckedRadioButtonIndex());
        }

        private void Radio2_CheckedChanged(object sender, EventArgs e)
        {
            NoiseAndLoad(GetCheckedRadioButtonIndex());
        }

        private void Radio3_CheckedChanged(object sender, EventArgs e)
        {
            NoiseAndLoad(GetCheckedRadioButtonIndex());
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            NoiseAndLoad(GetCheckedRadioButtonIndex());
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            NoiseAndLoad(GetCheckedRadioButtonIndex());
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            NoiseAndLoad(GetCheckedRadioButtonIndex());
        }

        private void RecognizeAndLoadPicture(Matrix recognizable)
        {
            var sampleVectors = _bitmapFilePaths
                .Select(path => new Bitmap(path))
                .Select(bitmap => bitmap.ToMatrix().ToVectorByColumns())
                .ToArray();
            Matrix weights = Recognizer.GenerateWeightsMatrix(sampleVectors);
            Vector inputVector = recognizable.ToVectorByColumns();
            Matrix recognized = Recognizer.RecognizeAsynchronously(weights, inputVector);
            Bitmap recognizedScaled = BitmapParser.Scale(recognized, DrawField.CellSize);
            picRecognized.Image = recognizedScaled;
        }

        private void BtnRecognizeDrawn_Click(object sender, EventArgs e)
        {
            RecognizeAndLoadPicture(_drawField.GetMatrix());
        }

        private string GetSelectedBitmapFilePath()
        {
            return _bitmapFilePaths[GetCheckedRadioButtonIndex()];
        }

        private void BtnRecognizeNoised_Click(object sender, EventArgs e)
        {
            Matrix noised = BitmapParser.Noise(new Bitmap(GetSelectedBitmapFilePath()), trackBarNoise.Value);
            RecognizeAndLoadPicture(noised);
        }

        private void BtnOpenStandart_Click(object sender, EventArgs e)
        {
            _bitmapFilePaths = new[] { "0.bmp", "1.bmp", "2.bmp", "3.bmp", "4.bmp" };
            try
            {
                picSample1.Image = BitmapParser.Scale(new Bitmap(_bitmapFilePaths[0]), DrawField.CellSize);
                picSample2.Image = BitmapParser.Scale(new Bitmap(_bitmapFilePaths[1]), DrawField.CellSize);
                picSample3.Image = BitmapParser.Scale(new Bitmap(_bitmapFilePaths[2]), DrawField.CellSize);
                picSample4.Image = BitmapParser.Scale(new Bitmap(_bitmapFilePaths[3]), DrawField.CellSize);
                picSample5.Image = BitmapParser.Scale(new Bitmap(_bitmapFilePaths[4]), DrawField.CellSize);
            }
            catch (Exception exception)
            {
                // ignored
            }
        }
    }
}