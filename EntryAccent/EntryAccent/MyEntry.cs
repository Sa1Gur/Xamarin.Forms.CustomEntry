using Xamarin.Forms;

namespace EntryAccent
{
    public class MyEntry : Entry
    {
        #region Bindable Properties
        public static readonly BindableProperty MyHighlightColorProperty = BindableProperty.Create(nameof(MyHighlightColor), typeof(Color), typeof(MyEntry));

        public static readonly BindableProperty MyHandleColorProperty = BindableProperty.Create(nameof(MyHandleColor), typeof(Color), typeof(MyEntry));

        public static readonly BindableProperty MyTintColorProperty = BindableProperty.Create(nameof(MyTintColor), typeof(Color), typeof(MyEntry));

        public static readonly BindableProperty SmallLabelStyleProperty = BindableProperty.Create(nameof(SmallLabelStyle), typeof(Style), typeof(MyEntry));
        #endregion

        #region Properties
        public Color MyHighlightColor
        {
            get => (Color)GetValue(MyHighlightColorProperty);
            set => SetValue(MyHighlightColorProperty, value);
        }
        public Color MyHandleColor
        {
            get => (Color)GetValue(MyHandleColorProperty);
            set => SetValue(MyHandleColorProperty, value);
        }
        public Color MyTintColor
        {
            get => (Color)GetValue(MyTintColorProperty);
            set => SetValue(MyTintColorProperty, value);
        }
        public Style SmallLabelStyle
        {
            get => (Style)GetValue(SmallLabelStyleProperty);
            set => SetValue(SmallLabelStyleProperty, value);
        }
        #endregion

        //#region Methods
        //public T GetValue<T>(BindableProperty property) => (T)GetValue(property);
        //#endregion
    }
}