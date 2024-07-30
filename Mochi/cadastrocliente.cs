<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="SeuApp.CadastroClientePage"
             Title="Cadastro de Cliente">
    <StackLayout Padding="20">
        <Label Text="Nome" FontSize="Medium" />
        <Entry x:Name="NomeEntry" Placeholder="Digite o nome" />

        <Label Text="Endereço" FontSize="Medium" Margin="0,20,0,0" />
        <Entry x:Name="EnderecoEntry" Placeholder="Digite o endereço" />

        <Label Text="Telefone" FontSize="Medium" Margin="0,20,0,0" />
        <Entry x:Name="TelefoneEntry" Placeholder="Digite o telefone" Keyboard="Telephone" />

        <StackLayout Orientation="Horizontal" HorizontalOptions="Center" Margin="0,20,0,0">
            <Button Text="Cancelar" BackgroundColor="Red" TextColor="White" Clicked="OnCancelClicked"/>
            <Button Text="Salvar" BackgroundColor="Green" TextColor="White" Clicked="OnSaveClicked" Margin="20,0,0,0"/>
        </StackLayout>
    </StackLayout>
</ContentPage>
