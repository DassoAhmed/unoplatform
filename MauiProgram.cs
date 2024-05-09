using CommunityToolkit.Maui.Markup;

public static MauiApp CreateMauiApp()
{
    var builder = MauiApp.CreateBuilder();
    // Initialise the toolkit
    builder.UseMauiApp<App>().UseMauiCommunityToolkitMarkup();
    // the rest of your logic...
}

new Entry()
    .Bind(Entry.TextProperty, static (ViewModel vm) => vm.RegistrationCode);

    new Entry().Size(200, 40);

    using static CommunityToolkit.Maui.Markup.GridRowsColumns;

class SampleContentPage : ContentPage
{
    public SampleContentPage()
    {
        Content = new Grid
        {
            RowDefinitions = Rows.Define(
                (Row.TextEntry, 36)),

            ColumnDefinitions = Columns.Define(
                (Column.Description, Star),
                (Column.Input, Stars(2))),

            Children =
            {
                new Label()
                    .Text("Code:")
                    .Row(Row.TextEntry).Column(Column.Description),

                new Entry
                {
                    Keyboard = Keyboard.Numeric,
                    BackgroundColor = Colors.AliceBlue,
                }.Row(Row.TextEntry).Column(Column.Input)
                 .FontSize(15)
                 .Placeholder("Enter number")
                 .TextColor(Colors.Black)
                 .Height(44)
                 .Margin(5, 5)
                 .Bind(Entry.TextProperty, static (ViewModel vm) vm => vm.RegistrationCode)
            }
        };
    }

    enum Row { TextEntry }
    enum Column { Description, Input }
}