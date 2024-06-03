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

	public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
		propertyName: nameof(Placeholder), returnType: typeof(string), declaringType: typeof(OutlinedEntryControl), defaultValue: null, defaultBindingMode: BindingMode.OneWay);

	public string Placeholder
	{
		get => (string) GetValue( PlaceholderProperty );
		set { SetValue(PlaceholderProperty, value); }
	}

    private void txtEntry_Focused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
		lblPlaceholder.FontSize = 11;
		lblPlaceholder.TranslateTo(0, -30, 80, easing: Easing.Linear);
    }

    private void txtEntry_Unfocused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {

		if (!string.IsNullOrWhiteSpace(Text))
		{
            lblPlaceholder.FontSize = 11;
            lblPlaceholder.TranslateTo(0, -26, 80, easing: Easing.Linear);
        }
		else
		{
			lblPlaceholder.FontSize = 15;
			lblPlaceholder.TranslateTo(0, 0, 80, easing: Easing.Linear);
		}
    }
}