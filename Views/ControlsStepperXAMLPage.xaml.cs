using MyFirstMobileApp.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MyFirstMobileApp.Views;

public partial class ControlsStepperXAMLPage : ContentPage
{
    public ControlsStepperXAMLPage()
    {

        InitializeComponent();
        BindingContext = new ControlsStepperXAMLViewModel();
        UpdateUI(stepper.Value);
    }

    private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateUI(e.NewValue);
    }

    private void UpdateUI(double value)
    {
        RotatingLabel.Rotation = value;
        DisplayLabel.Text = $"The Stepper value is {value:F0}";
    }

}