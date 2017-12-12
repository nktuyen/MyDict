<!DOCTYPE html>

</<html>
<head>
    <meta charset="UTF-8" />
    <title>MyDict</title>

    <style>
        #frm_login {
            display:block;
            border: solid 1px #AAAAAA;
            padding:0;
            width: 400px;
            height: auto;
        }
        input[type="text"],  input[type="password"], select {
            display: :block;
            width:160px;
            margin-left:10px;
        }

        .form_title{
            display: block;
            width: 100%;
            background-color: #999999;
            font-weight: bold;
            color: white;
        }

        .input_title{
            display: block;
            width: 100px;
            margin-left:10px;
        }

        #button{
            display: block;
            width: 100%;
            padding-left: 10px;
        }
        .td_input {
            display: table-cell;
            padding: 0;
            margin: 0;
            text-align: center;
            width: auto;
            height: auto;
        }
        .td_input input {
            display: block;

        }
    </style>
    <script src="./scripts/jquery-3.2.1.min.js"></script>
    <script src="./scripts/sha256.js"></script>
    <script>
        function updateUser(id) {
            alert('updating...'+id);
        }

    function deleteUser(id) {
        alert('deleting...'+id);
    }

        $(document).ready(function() {
            $("#btn_login").click(function() {
                var data = { __svc__: $("#__svc__").val(), __usr__: $("#__usr__").val(), __pwd__ : Sha256.hash($("#__pwd__").val(),'string'), __cri__:$("#__cri__").val(), __val__: $("#__val__").val()};
                $.get('services/index.php', data, function(data) {
                    var response = JSON.parse(data);
                    var users = response.data;
                    var html = '<table cellpadding="0" cellspacing="0" style="border:solid 1px #dddddd;padding:0;"><thead><tr><th>id</th> <th>name</th> <th>password</th> <th>Email</th> <th>First Name</th> <th>Last Name</th> <th>Birthday</th> <th>Sex</th> <th>Registered</th></tr></thead><tbody>';
                    for(var i=0;i<users.length;i++) {
                        var user = users[i];
                        html += '<tr>';
                        html += '<td>';
                        html += user.id;
                        html += '</td>';

                        html += '<td>';
                        html += user.name;
                        html += '</td>';

                        html += '<td class="td_input"><input type="text" value="';
                        html += user.password;
                        html += '"/></td>';

                        html += '<td class="td_input"><input type="text" value="';
                        html += user.email;
                        html += '"/></td>';

                        html += '<td class="td_input"><input type="text" value="';
                        html += user.first_name;
                        html += '"/></td>';

                        html += '<td class="td_input"><input type="text" value="';
                        html += user.last_name;
                        html += '"/></td>';

                        html += '<td class="td_input"><input type="text" value="';
                        html += user.birth_day+'/'+user.birth_month+'/'+user.birth_year;
                        html += '"/></td>';

                        html += '<td class="td_input"><input type="text" value="';
                        html += user.gender;
                        html += '"/></td>';

                        html += '<td class="td_input"><input type="text" value="';
                        html += user.registered_date;
                        html += '"/></td>';

                        html += '<td class="td_input"><input type="button" value="';
                        html += 'Update" onclick="updateUser('+user.id+');';
                        html += '"/></td>';

                        html += '<td class="td_input"><input type="button" value="';
                        html += 'Delete" onclick="deleteUser('+user.id+');';
                        html += '"/></td>';

                        html += '</tr>';
                    }
                    html += '</tbody></table>';
                    $("#body").html(html);
                });
            });

            $("#frm_login").submit(function() {
               var pwd = Sha256.hash($("#__pwd__").val(),'string');
               $("#__pwd__").val(pwd);
            });
        });
    </script>
</head>
<body>
    <form id="frm_login" name="frm_login" action="services/index.php" method="GET">
        <label id="lbl_caption" class="form_title">LOGIN</label>

        <label for="__usr__" class="input_title">Username:</label>
        <input type="text" name="__usr__" id="__usr__"/>

        <label for="__pwd__" class="input_title">Password:</label>
        <input type="password" name="__pwd__" id="__pwd__" />

        <label for="__svc__" class="input_title">Service:</label>
        <select name="__svc__" id="__svc__">
            <option value="">< Select service ></option>
            <option value="country" selected="true">Country</option>
            <option value="user">User</option>
            <option value="language">Language</option>
            <option value="class">Class</option>
            <option value="category">Category</option>
            <option value="vocabulary">Vocabulary</option>
            <option value="permission">Permission</option>
            <option value="gender">Gender</option>
        </select>

        <label for="__cri__" class="input_title">Criteria:</label>
        <select name="__cri__" id="__cri__">
            <option value="">< Select criteria ></option>
            <option value="id" selected="true">id</option>
            <option value="name">name</option>
            <option value="title">title</option>
        </select>

        <label for="__val__" class="input_title">Value:</label>
        <input type="text" name="__val__" id="__val__" />

        <div id="button">
            <input type="button" id="btn_login" name="btn_login" value ="Submit" />
            <input type="reset" id="btn_reset" name="btn_reset" value  ="Reset" />
        </div>
    </form>
    <p id="body"></p>
</body>
</html>