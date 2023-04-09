using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace UmlDiagramme
{
    public partial class Form1 : Form
    {
        private List<string> _umlTypes;
        private int _currentUmlTypeIndex;
        private Random _random;
        private int _correctAnswersInARow;

        public Form1()
        {
            InitializeComponent();
            InitializeUmlTypes();

            _random = new Random();
            _correctAnswersInARow = 0;
            LoadRandomUmlType();
        }

        private void InitializeUmlTypes()
        {
            _umlTypes = new List<string>
            {
                "Klassendiagramm",
                "Objektdiagramm",
                "Anwendungsfall-Diagramm",
                "Sequenzdiagramm",
                "Kommunikationsdiagramm",
                "Zustandsdiagramm",
                "Aktivitätsdiagramm"
            };

            listBoxUmlTypes.DataSource = _umlTypes;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmSelection();
        }

        private void ConfirmSelection()
        {
            string selectedItem = (string)listBoxUmlTypes.SelectedItem;
            string currentUmlType = _umlTypes[_currentUmlTypeIndex];

            if (selectedItem == currentUmlType)
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "Richtig!";
                _correctAnswersInARow++;
                LoadRandomUmlType();
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Falsch! Versuchen Sie es erneut.";
                _correctAnswersInARow = 0;
            }
        }



        private void LoadRandomUmlType()
        {
            _currentUmlTypeIndex = _random.Next(_umlTypes.Count);
            ShowUmlDiagram(_umlTypes[_currentUmlTypeIndex]);
        }


        private void ShowUmlDiagram(string umlType)
        {
            string resourceName = $"UmlDiagramme.Images.{umlType}.png";

            using Stream imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
            if (imageStream != null)
            {
                pictureBoxDiagram.Image = Image.FromStream(imageStream);
            }
            else
            {
                MessageBox.Show($"Bild für {umlType} nicht gefunden. Bitte stellen Sie sicher, dass das Bild als eingebettete Ressource im Projekt vorhanden ist.");
            }
        }

        private void listBoxUmlTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
