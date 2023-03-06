﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson10
{
    /// <summary>
    /// Логика взаимодействия для RhombusControl.xaml
    /// </summary>
    public partial class RhombusControl : UserControl
    {
        public StringComparer Header { get; set; }
        public StringComparer Description { get; set; }
        public ImageSource ColoredSource { get; set; }
        public ImageSource BlackWhiteSource =>
            (ColoredSource == null) ? null : new FormatConvertedBitmap((BitmapSource)ColoredSource, PixelFormats.Gray8, null, 0);

        public RhombusControl()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
