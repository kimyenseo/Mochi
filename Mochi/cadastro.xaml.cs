<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="YourNamespace.MainPage"
             BackgroundColor="#B0C4DE">

    <StackLayout VerticalOptions="Center" HorizontalOptions="Center">

        <!-- Imagem no topo -->
        <Image Source="profile_icon.png" WidthRequest="100" HeightRequest="100" />

        <!-- Campo de Nome -->
        <Entry x:Name="entryNome" Placeholder="NOME" WidthRequest="200" HorizontalOptions="Center" />

        <!-- Campo de Senha -->
        <Entry x:Name="entrySenha" Placeholder="SENHA" IsPassword="True" WidthRequest="200" HorizontalOptions="Center" />

        <!-- Botão de Cadastro -->
        <Button Text="IR PARA TELA DE CADASTRO" WidthRequest="200" HorizontalOptions="Center" Clicked="OnCadastroButtonClicked" />

        <!-- Botões de Cancelar e Confirmar -->
        <StackLayout Orientation="Horizontal" HorizontalOptions="Center" Spacing="20">
            <Button Text="X" BackgroundColor="Red" TextColor="White" WidthRequest="50" Clicked="OnCancelButtonClicked" />
            <Button Text="✓" BackgroundColor="Green" TextColor="White" WidthRequest="50" Clicked="OnConfirmButtonClicked" />
        </StackLayout>
    </StackLayout>
</ContentPage>
