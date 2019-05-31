using EntryAccent.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]
namespace EntryAccent.iOS.Renderers
{
    public class MyEntryRenderer: EntryRenderer
    {        
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            TintCustomization(Control, e.NewElement as MyEntry);
        }
        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control == null) return;

            TintCustomization(Control, sender as MyEntry);
        }

        private void TintCustomization(UITextField Control, MyEntry customEntry)
        {
            if (Control == null) return;

            if (customEntry != null)
            {
                UITextField textField = Control;
                textField.BorderStyle = UITextBorderStyle.None;
                textField.TintColor = customEntry.MyHandleColor.ToUIColor();
            }
        }
    }
}
