<!DOCTYPE html>

</<html>
<head>
    <meta charset="UTF-8" />
    <title>MyDict</title>

    <style>
        #frm_login {
            display:block;
            border: solid 1px red;
            padding:0;
            width: 300px;
            height: auto;
        }

        #lbl_caption {
            display: :block;
            width:300;
            height: auto;
            background-color: #DDDDDD;
        }

        #lbl_user, #lbl_pwd {
            display: :block;
        }
    </style>
</head>
<body>
    <form id="frm_login" name="frm_login" method="POST" action="/services/index.php">
        <label id="lbl_caption">LOGIN</label>
        <label for="txt_user" id="lbl_user">Username:</label>
        <input type="text" id="txt_user" name="txt_user" maxlength="255" placeholder="Enter your username..." />

        <label for="txt_pwd" id="lbl_pwd">Password:</label>
        <input type="password" id="txt_pwd" name="txt_pwd" />

        <input type="submit" id="btn_login" name="btn_login" value ="Login" />
        <input type="reset" id="btn_reset" name="btn_reset" value  ="Reset" />
    </form>
</body>
</html>