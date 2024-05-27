namespace AppFinancias.CustomContols;

public partial class OutlinedEntryControl : Grid
{
	public OutlinedEntryControl()
	{
		InitializeComponent();
	}

	public static readonly BindableProperty TextProperty = BindableProperty.Create(
		propertyName: nameof(Text), returnType:typeof (string), declaringType:typeof (OutlinedEntryControl), defaultValue:null, defaultBindingMode: BindingMode.TwoWay);

	public string Text
	{
		get => (string)GetValue( TextProperty );
		set => SetValue( TextProperty, value );
	}
}