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
    </style>
    <script src="./scripts/jquery-3.2.1.min.js"></script>
</head>
<body>
    <form id="frm_login" name="frm_login" action="services/index.php">
        <label id="lbl_caption" class="form_title">LOGIN</label>

        <label for="__usr__" class="input_title">Username:</label>
        <input type="text" name="__usr__"/>

        <label for="__pwd__" class="input_title">Password:</label>
        <input type="password" name="__pwd__" />

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
        </select> <br/>

        <label for="__dat__" class="input_title">Data:</label>
        <input type="text" name="id" />

        <div id="button">
            <input type="submit" id="btn_login" name="btn_login" value ="Submit" />
            <input type="reset" id="btn_reset" name="btn_reset" value  ="Reset" />
        </div>
    </form>
    <p id="body"></p>
</body>
</html>