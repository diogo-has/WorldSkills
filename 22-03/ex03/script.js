const enter = (event) => {if (event.keyCode === 13) login();}

const next = (event) => {if (event.keyCode === 13) document.getElementById('pass').focus();}

function login() {
    const credentials = {
        'admin': {'12345': true}
    }

    const user = document.getElementById('user').value;
    const pass = document.getElementById('pass').value;

    try {
        if (credentials[user][pass]) window.location.href = 'success.html'; else window.location.href = 'fail.html';
    } catch {
        window.location.href = 'fail.html'
    }
}

