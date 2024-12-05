<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Semestral._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="welcomeTitle">
            <h1 id="welcomeTitle" class="welcome-title">Bienvenido al Sistema de Riego</h1> <!-- Se agrega la clase welcome-title -->
            <p class="lead">Este sistema está diseñado para ayudarte a gestionar el riego de tus cultivos de manera eficiente y práctica. Puedes registrar usuarios, gestionar tipos de plantas, realizar riegos y consultar los próximos riegos.</p>
            <p><a href="Usuarios.aspx" class="btn btn-primary btn-md">Gestionar Usuarios</a></p>
            <p><a href="TiposPlanta.aspx" class="btn btn-primary btn-md">Gestionar Tipos de Planta</a></p>
            <p><a href="Riego.aspx" class="btn btn-primary btn-md">Registrar Riego</a></p>
            <p><a href="ProximosRiegos.aspx" class="btn btn-primary btn-md">Ver Próximos Riegos</a></p>
        </section>

        <div class="row">
            <section class="col-md-6" aria-labelledby="howItWorksTitle">
                <h2 id="howItWorksTitle" class="secondary-title">¿Cómo funciona?</h2> <!-- Se agrega la clase secondary-title -->
                <p>
                    Con este sistema puedes registrar los tipos de plantas, establecer la frecuencia de riego, y asignar usuarios para el seguimiento del riego. Además, podrás visualizar un historial de riegos y programar futuros riegos.
                </p>
            </section>
            <section class="col-md-6" aria-labelledby="whyItMattersTitle">
                <h2 id="whyItMattersTitle" class="secondary-title">¿Por qué es importante?</h2> <!-- Se agrega la clase secondary-title -->
                <p>
                    El riego adecuado es crucial para el crecimiento saludable de las plantas. Este sistema te ayudará a automatizar y gestionar el riego de manera eficiente, asegurando que tus cultivos reciban la cantidad exacta de agua que necesitan.
                </p>
            </section>
        </div>
    </main>

</asp:Content>


