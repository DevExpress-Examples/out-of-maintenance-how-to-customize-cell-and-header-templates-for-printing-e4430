using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Printing;

namespace DXSample {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            List<TestData> list = new List<TestData>();
            for (int i = 0; i < 20; i++) {
                list.Add(new TestData() { Number = i, Text = "Row " + i });
			}
            grid.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            DocumentPreviewWindow preview = new DocumentPreviewWindow();
            PrintableControlLink link = new PrintableControlLink(view);
            LinkPreviewModel model = new LinkPreviewModel(link);
            preview.Model = model;
            link.CreateDocument(true);
            preview.ShowDialog();
        }
    }
    public class TestData {
        public int Number { get; set; }
        public string Text { get; set; }
    }
}
