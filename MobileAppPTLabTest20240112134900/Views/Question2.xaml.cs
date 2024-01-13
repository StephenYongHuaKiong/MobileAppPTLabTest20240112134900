using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Markup;
using System.Text.RegularExpressions;

namespace MobileAppPTLabTest20240112134900.Views;

public partial class Question2 : ContentPage
{
	public Question2()
	{
		InitializeComponent();

		NumericValidationBehavior numValidateBehaviour = new NumericValidationBehavior
		{
			Flags = ValidationFlags.ValidateOnValueChanged,
			MinimumValue = 0,
			MaximumDecimalPlaces = 0
		};

		TextValidationBehavior txtValidateBehaviour = new TextValidationBehavior
		{
			Flags = ValidationFlags.ValidateOnValueChanged,
			MinimumLength = 6
		};

		PhoneEntry.Behaviors.Add(numValidateBehaviour);
		PasswordEntry.Behaviors.Add(txtValidateBehaviour);

		TermsAndConditionsCheckBox.CheckedChanged += (sender, e) => TACCheckChanged(sender, e);
		TermsAndConditionsLabel.ClickGesture(new Action(() => TACLblClicked()));
	}

	private void TACLblClicked()
	{
		TermsAndConditionsCheckBox.IsChecked = !TermsAndConditionsCheckBox.IsChecked;
	}

	private void TACCheckChanged(object sender, EventArgs e)
	{
		if (TermsAndConditionsCheckBox.IsChecked == true)
		{
			RegisterButton.IsEnabled = true;
		}
		else
		{
			RegisterButton.IsEnabled = false;
		}
	}

	private void CheckPhone(object sender, EventArgs e)
	{
		if ((Regex.IsMatch(PhoneEntry.Text, @"^[0-9]+$")) || (string.IsNullOrWhiteSpace(PhoneEntry.Text)))
		{
			InvalidPhoneLbl.IsVisible = false;
		}
		else
		{
			InvalidPhoneLbl.IsVisible = true;
		}
	}

	private void CheckPassword(object sender, EventArgs e)
	{
		if (PasswordEntry.Text.Length >= 6 || (string.IsNullOrWhiteSpace(PasswordEntry.Text)))
        {
			InvalidPasswordLbl.IsVisible = false;
		}
		else
		{
			InvalidPasswordLbl.IsVisible = true;
		}
	}
}