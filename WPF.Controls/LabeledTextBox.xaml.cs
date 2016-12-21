using System;
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
using WPF.Controls.Enums;

namespace WPF.Controls
{
    /// <summary>
    /// Interaction logic for LabeledTextBox.xaml
    /// </summary>
    public partial class LabeledTextBox : UserControl
    {
        public LabeledTextBox()
        {
            InitializeComponent();
        }
        #region Label DependencyProperty

        /// <summary>
        /// Gets or sets the Label for the text box
        /// </summary>
        public String Label
        {
            get { return (String)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string),
              typeof(LabeledTextBox), new PropertyMetadata(""));

        #endregion

        #region Value Dependency Propery

        /// <summary>
        /// Gets or sets the text value of the text box
        /// </summary>
        public object Value
        {
            get { return (object)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(object),
              typeof(LabeledTextBox), new PropertyMetadata(null));

        #endregion

        #region LabelPosition Dependency Propery

        /// <summary>
        /// Gets or sets the postion the label will be located relative to the text box
        /// </summary>
        public LabelPosition LabelPosition
        {
            get { return (LabelPosition)GetValue(LabelPositionProperty); }
            set { SetValue(LabelPositionProperty, value); }
        }

        public static readonly DependencyProperty LabelPositionProperty =
            DependencyProperty.Register("LabelPosition", typeof(object),
              typeof(LabeledTextBox), new PropertyMetadata(LabelPosition.Left));

        #endregion
    }
}
