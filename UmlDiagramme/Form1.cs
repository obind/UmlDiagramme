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
        private List<string> _networkTopologies;
        private int _currentIndex;
        private Random _random;
        private int _correctAnswersInARow;
        private bool _isUmlSelected;

        public Form1()
        {
            InitializeComponent();
            InitializeUmlTypes();
            InitializeNetworkTopologies();

            _random = new Random();
            _correctAnswersInARow = 0;
            _isUmlSelected = true;
            LoadRandomItem();
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

        private void InitializeNetworkTopologies()
        {
            _networkTopologies = new List<string>
            {
                "Stern-Topologie",
                "Ring-Topologie",
                "Bus-Topologie",
                "Baum-Topologie",
                "Vollständig vermaschte Topologie",
                "Unregelmäßige Topologie"
            };
            listBoxUmlTypes.DataSource = _networkTopologies;
        }

        // Implement the event handler for the ComboBox
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isUmlSelected = comboBoxCategory.SelectedIndex == 0;
            listBoxUmlTypes.DataSource = _isUmlSelected ? _umlTypes : _networkTopologies;
            LoadRandomItem();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmSelection();
        }

        private void ConfirmSelection()
        {
            string selectedItem = (string)listBoxUmlTypes.SelectedItem;
            string currentItem = _isUmlSelected ? _umlTypes[_currentIndex] : _networkTopologies[_currentIndex];

            if (selectedItem == currentItem)
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "Richtig!";
                _correctAnswersInARow++;
                LoadRandomItem();
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Falsch! Versuchen Sie es erneut.";
                _correctAnswersInARow = 0;
            }
        }

        private void LoadRandomItem()
        {
            _currentIndex = _random.Next(_isUmlSelected ? _umlTypes.Count : _networkTopologies.Count);
            ShowDiagram(_isUmlSelected ? _umlTypes[_currentIndex] : _networkTopologies[_currentIndex]);
        }

        private void ShowDiagram(string itemName)
        {
            string category = _isUmlSelected ? "UmlDiagramme" : "NetworkTopologies";
            string resourceName = $"UmlDiagramme.Images.{category}.{itemName}.png";


            using Stream imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
            if (imageStream != null)
            {
                pictureBoxDiagram.Image = Image.FromStream(imageStream);
            }
            else
            {
                MessageBox.Show($"Bild für {itemName} nicht gefunden. Bitte stellen Sie sicher, dass das Bild als eingebettete Ressource im Projekt vorhanden ist.");
            }
        }


        private void listBoxUmlTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



