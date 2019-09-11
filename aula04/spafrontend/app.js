let endPoint = 'http://localhost:50410/api/v1/';

function carregaCategoria(){
    let url = endPoint + 'categorias'

    let xhr = new XMLHttpRequest();
    xhr.open('GET', url);
    xhr.onloadend =  () => {
        let $lista = document.querySelector('#drpCategoria');
        let categorias = JSON.parse(xhr.response);
        categorias.forEach(item => {
            $lista.innerHTML += `<option value="${item.id}">${item.nome}</option>`
        });

    }
    xhr.send()
}

function carregarProdutos(){
    let url = endPoint + "produtos";
    let xhr = new XMLHttpRequest();

    xhr.open("GET", url);
    xhr.onloadend = function () {
        //console.log(xhr);
        let produtos = JSON.parse(xhr.response);
        // console.log(produtos);
        montarProdutos(produtos)
    }
    xhr.send();
}

function montarProdutos(produtos){
    let $tbody = document.querySelector('#tblProdutos>tbody');
    let $tr = '';
    // for (let i = 0; i < produtos.length; i++) {
    //     const element = produtos[i];
    //     console.log(element);
    //     $tr += `<tr>
    //                 <td>${element.id}</td>
    //                 <td>${element.nome}</td>
    //                 <td>${element.categoriaName}</td>
    //             </tr>`;

    // }

     produtos.forEach((item, index ) => {
        // console.log(item);
        $tr += `<tr>
                    <td>${item.nome}</td>
                    <td>${item.categoriaName}</td>
                    <td>${item.valorUnitario}</td>
                    <td>
                        <button type="button" class="btn btn-primary btn-sm" onclick="carregarProduto(${item.id})">Editar</button>
                        <button type="button" class="btn btn-secondary btn-sm" onclick="excluirProduto(${item.id}, '${item.nome}')">Excluir</button>
                    </td>
                </tr>`;

     });

    $tbody.innerHTML = $tr;
}

function adicionarProduto() {
    
}

function carregarProduto(id){
    let url = endPoint + "produtos/" + id;
    let xhr = new XMLHttpRequest();

    xhr.open("GET", url);
    xhr.onloadend = () => {
        let produtos = JSON.parse(xhr.response);
        carregarForm(produtos);
    }
    xhr.send();
}

function salvarProduto() {
    let produto = {
        id: document.querySelector('#txtId').value,
        nome: document.querySelector('#txtNome').value,
        categoriaId: document.querySelector('#drpCategoria').value,
        valorUnitario: document.querySelector('#txtValorUnitario').value
    }
    let json = JSON.stringify(produto);
    //console.log(json);

    let url = endPoint + 'Produtos/';
    let xhr = new XMLHttpRequest();

    let param = {method : 'POST', uri : url}

    if (produto.id > 0) {
        param.metho = 'PUT',
        param.uri += produto.id
    }

    xhr.open(param.method, param.uri);
    xhr.onloadend = () => {
       if (xhr.status == 200) {
           alert('Produto cadastrado c/sucasso');
           carregarProdutos();
           adicionarProduto();
       } else {
           alert('Erro ao tentar cadastrar o produto')
           console.log(xhr);
       }
    }
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(json);
}

function excluirProduto(id, nome) {
    let resp = confirm(`Deseja excluir o id ${id} e nome ${nome}`)

    if (resp) {
        let url = endPoint + "produtos/" + id;
        let xhr = new XMLHttpRequest();

        xhr.open("DELETE", url);
        xhr.onloadend =  () => {
            if (xhr.status == 204) {
                alert('Excluido com sucesso');
                carregarProdutos();
            }
            
        }
        xhr.send();
    }
}

document.querySelector('#dadosForm').onsubmit = function(e){
    e.preventDefault();
    salvarProduto();
}


function carregarForm(produtos){
    document.querySelector('#txtId').value = produtos.id;
    document.querySelector('#txtNome').value = produtos.nome;
    document.querySelector('#drpCategoria').value = produtos.categoriaId;
    document.querySelector('#txtValorUnitario').value = produtos.valorUnitario;
    document.querySelector('#txtNome').focus();


}

carregaCategoria();
carregarProdutos();
adicionarProduto();