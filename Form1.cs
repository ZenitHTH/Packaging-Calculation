namespace Packaging_Calculation
{
    using oxygenAbs = Packaging_Calculation.OxygenAbsorber;
    using silicaGel = Packaging_Calculation.SilicaGel;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Oxygen Absorber

        private void btnSGSubmit_Click(object sender, EventArgs e)
        {
            silicaGel sg = new silicaGel((float)sg_height.Value, (float)sg_Length.Value , (float)sg_width.Value);
            SG_PackageVolume.Text = sg.PackageVolume().ToString("0,0.00");
            SG_SilicaGelVolume.Text = sg.SlilcaGelVolume().ToString("0,0.00");
        }

        private void btnOXASubmit_Click(object sender, EventArgs e)
        {
            oxygenAbs oxa = new oxygenAbs((float)ox_length.Value, (float)ox_width.Value, (float)ox_height.Value, (float)ox_foodWeight.Value);
            OX_PackageVolume.Text = oxa.PackageVolume().ToString("0,0.00");
            OX_Oxygen_Absorber_Volume.Text = oxa.OxygenAbsorberVolume().ToString("0,0.00");
        }

        private void Reset_SG_Click(object sender, EventArgs e)
        {
            sg_height.Value = 0;
            sg_Length.Value = 0;
            sg_width.Value = 0;
        }

        private void Reset_OX_Click(object sender, EventArgs e)
        {
            ox_foodWeight.Value = 0;
            ox_height.Value = 0;
            ox_length.Value = 0;
            ox_width.Value = 0;
        }
    }
}