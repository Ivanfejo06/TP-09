function ValidatePassword()
{  
    let leng = false;
    let spec = false;
    let upp = false;
    let password = document.getElementById("c1")
    var format = /[!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?]+/;

    //Checking length
    if(password.value.length >= 8){leng = true;}

    //Checking for special characters
    for (let i = 0; i < password.value.length; i++) {
        const element = password.value[i];
        if(format.test(element)){spec = true;}
    }

    //Checking for an uppercase
    for (let i = 0; i < password.value.length; i++) {
        const element = password.value[i];
        let txt = element;
        if (element === txt.toUpperCase()) {upp = true;}
    }

    //Validate all 3
    if(!leng)
    {
        password.value = "";
        passwordAlert.textContent = "La contraseña debe tener al menos 8 caracteres.";
    }
    else {passwordAlert.textContent = "";}
    if(!spec)
    {
        password.value = "";
        passwordAlert.textContent = "La contraseña debe tener al menos 1 caracter especial.";
    }
    else {passwordAlert.textContent = "";}
    if(!upp)
    {
        password.value = "";
        passwordAlert.textContent = "La contraseña debe tener al menos 1 letra mayuscula.";
    }
    else {passwordAlert.textContent = "";}
}

function ValidateRepeat()
{
    let c1 = document.getElementById("c1")
    let c2 = document.getElementById("c2")

    if(c1.value === c2.value){RepeatAlert.textContent = ""}
    else 
    {
        c2.value = "";
        RepeatAlert.textContent = "La contraseñas no coinciden.";
    }
}

function ValidateEmail()
{
    var mailformat = /^\w+([.-]?\w+)*@\w+([.-]?\w+)*(\.\w{2,3})+$/;
    let mail = document.getElementById("mail")
    if(mail.value.test(mailformat)){MailAlert.textContent = "";}
    else
    {
        mail.value = "";
        MailAlert.textContent = "El mail introducido no cumple con el formato de mail.";
    }
}