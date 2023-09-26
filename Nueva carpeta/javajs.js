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
    if(leng && spec && upp){password.value = "messi"}
    else {password.value = "menno"}
}

function ValidateRepeat()
{
    let c1 = document.getElementById("c1")
    let c2 = document.getElementById("c2")

    if(c1.value === c2.value){c1.value = "menno"}
    else {c2.value = "menno"}
}

function ValidateEmail()
{
    var mailformat = /^\w+([.-]?\w+)*@\w+([.-]?\w+)*(\.\w{2,3})+$/;
    let mail = document.getElementById("mail")
    if(mail.value.test(mailformat)){mail.value = "caca";}
    else{return mail.value = "cucu";}
}