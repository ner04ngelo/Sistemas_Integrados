<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroProteinas.aspx.cs" Inherits="RegistroProteinas.RegistroProteinas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Registro de Proteinas</title>
    <script type="text/javascript" src="Scripts/jquery-2.0.2.js"></script>
</head>
<body>
    <form id="form1" method="post" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>

        <h1>Registro de proteinas</h1>
        <div>
            <label for="select-user">Seleccione un usuario</label>
            <select id="select-user">
            </select>
        </div>
        <hr />
        <div>
            <h2>Agregar nuevo usuario</h2>
            <br />
            <label for="name">Nombre</label>
            <input id="name" type="text" /><br />
            <label for="goal">Meta</label>
            <input id="goal" type="text" /><br />
            <input id="add-new-user-button" type="button" onclick="AddNewUser()" value="Add" />
        </div>

        <hr />
        <div>
            <h2>Agregar Proteinas</h2>
            <label for="amount">Amount</label>
            <input id ="amount" type="text" /><br />
            <input id ="add-button" type="button" onclick="AddProtein()" value="Add" />
        </div>
        <div>
            Total: <span id ="user-total"></span>
            <br />
            Goal: <span id="user-goal"></span>
        </div>



    </form>

</body>



<script type="text/javascript">

    var _users;

    $(document).ready(function () {
        $('#select-user').change(function () {
            UpdateUserData();
        })

        PopulateSelectUsers();
    })


    function PopulateSelectUsers() {
        var selectUser = $('#select-user');
        selectUser.empty();
        PageMethods.ListUser(function (users) {
            _users = users;
            for (var i = 0; i < users.length; i++) {
                selectUser.append(new Option(users[i].Name, users[i].UserId));
            }

            UpdateUserData();
        })
    }


    function AddNewUser() {
        var name = $("#name").val();
        var goal = $("#goal").val();

        $.ajax({
            type: "POST",
            url: "RegistroProteinas.aspx/AgregarUsuario",
            data: JSON.stringify({ 'name': name, 'goal': goal }),
            contentType: 'application/json; charset=utf-8',
            dataType: "json"
        }).done(PopulateSelectUsers);
    }


    function AddProtein() {
        var amount = $("#amount").val();
        var userId = $("#select-user").val();
        PageMethods.AgregarProteinas(amount, userId, function (newTotal) {
            for (var i = 0; i < _users.length; i++) {
                if (_users[i].UserId == userId)
                    _users[i].Total = newTotal;

            }

            UpdateUserData();

        });
    }


    function UpdateUserData() {
        var index = $("#select-user")[0].selectedIndex;
        if (index < 0)
            return;

        $("#user-goal").text(_users[index].Goal);
        $("#user-total").text(_users[index].Total);
    }

</script>


</html>
