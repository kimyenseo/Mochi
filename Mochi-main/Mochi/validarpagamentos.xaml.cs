<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="YourNamespace.InboxPage"
             BackgroundColor="#B0C4DE">

    <StackLayout Padding="10">

        <!-- Header -->
        <Frame BackgroundColor="White" Padding="10" CornerRadius="0" Margin="0,20,0,20">
            <StackLayout Orientation="Horizontal" HorizontalOptions="Center">
                <Label Text="Validar pagamentos" VerticalOptions="Center" TextColor="Black" FontSize="Medium"/>
                <Image Source="database_icon.png" WidthRequest="30" HeightRequest="30" Margin="10,0,0,0"/>
            </StackLayout>
        </Frame>

        <!-- Content Area -->
        <StackLayout VerticalOptions="CenterAndExpand" HorizontalOptions="CenterAndExpand">
            <!-- Pode adicionar conteúdo adicional aqui se necessário -->
        </StackLayout>

        <!-- Buttons -->
        <Grid Padding="10" VerticalOptions="EndAndExpand">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="*" />
                <ColumnDefinition Width="*" />
                <ColumnDefinition Width="*" />
            </Grid.ColumnDefinitions>

            <Button Text="back" Grid.Column="0" VerticalOptions="End" Clicked="OnBackButtonClicked"/>
            <Button BackgroundColor="Red" ImageSource="delete_icon.png" Grid.Column="1" WidthRequest="60" HeightRequest="60" VerticalOptions="End" Clicked="OnDeleteButtonClicked"/>
            <Button BackgroundColor="Transparent" ImageSource="check_icon.png" Grid.Column="2" WidthRequest="60" HeightRequest="60" VerticalOptions="End" Clicked="OnCheckButtonClicked"/>
        </Grid>
        
    </StackLayout>
</ContentPage>
