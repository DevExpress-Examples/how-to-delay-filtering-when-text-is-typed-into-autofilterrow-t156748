using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Xpf.Core.Native;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;

namespace AutoFilterRowPostDelay
{
    public class PostDelayHelper
    {
        public static DependencyProperty DelayTimeProperty = DependencyProperty.RegisterAttached("DelayTime",
            typeof(int), typeof(PostDelayHelper),
            new PropertyMetadata(0, new PropertyChangedCallback(DelayTimeChanged)));

        public static void SetDelayTime(DependencyObject d, int value)
        {
            d.SetValue(DelayTimeProperty, value);
        }

        public static int GetDelayTime(DependencyObject d)
        {
            return (int)d.GetValue(DelayTimeProperty);
        }

        public static void DelayTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if ((int)e.NewValue >= 0 && d is GridColumn)
            {
                ((d as GridColumn).View as GridViewBase).ShownEditor += delegate(object sender, EditorEventArgs args)
                {
                    if (args.RowHandle == GridControl.AutoFilterRowHandle && args.Column == d as GridColumn)
                    {
                        (args.Editor as BaseEdit).EditValuePostDelay = GetDelayTime(d);
                        (args.Editor as BaseEdit).EditValuePostMode = PostMode.Delayed;
                    }
                };
            }
        }
    }
}
