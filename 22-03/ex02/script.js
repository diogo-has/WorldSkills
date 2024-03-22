function changeImg() {
    const target = document.getElementById('imagem')
    const img = document.getElementById('input').files[0];
    

    target.src = URL.createObjectURL(img);
}

function aumentar() {
    const target = document.getElementById('imagem')
    var currentWidth = target.clientWidth;
    target.style.width = (currentWidth + 100) + 'px';
}

function diminuir() {
    const target = document.getElementById('imagem')
    var currentWidth = target.clientWidth;
    target.style.width = (currentWidth - 100) + 'px';
}
