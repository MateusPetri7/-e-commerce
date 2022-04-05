let myJson;
let botoes;
let produtoAtualizado;

const listaPrincipal = document.querySelector('#list-products');
const listaCarrinho = document.querySelector('#cart-products');


myJson = GetProdutos();
function GetProdutos(){
  try {
    //transformar async dps
    //var response = await fetch('https://localhost:5500/')
    //var myJson = await response.json();
    myJson = [
      {
        id: "guid louco1",
        link: "./images/image01.png",
        status: false,
        descricao: "aaa 1",
        preco: "999 1"
      },
      {
        id: "guid louco",
        link: "./images/image02.png",
        status: false,
        descricao: "aaa",
        preco: "999"
      },
      {
        id: "guid louco",
        link: "./images/image03.png",
        status: true,
        descricao: "aaa",
        preco: "999"
      },
    ]

    return myJson;

  } catch (error) {
    console.log(error)
  }
}

PopularProdutos(myJson);
function PopularProdutos (myJson){

  for (let index = 0; index < myJson.length; index++) {

    if (myJson[index].status){
      if (listaCarrinho == null){
        continue;
      }

      listaCarrinho.innerHTML += `<div id="card" class="card">
          <div class="img">
            <img src="${myJson[index].link}" alt="">
          </div>
          <div class="description">
            <h2>${myJson[index].descricao}</h2>
            <h3>R$ ${myJson[index].preco}</h3>
          </div>
          <div class="button">
            <input type="button" id="button" value="Remover do carrinho">
          </div>
        </div>`
    }
    else{
      if (listaPrincipal == null){
        continue;
      }

      listaPrincipal.innerHTML += `<div id="card" class="card">
        <div class="img">
          <img src="${myJson[index].link}" alt="">
        </div>
        <div class="description">
          <h2>${myJson[index].descricao}</h2>
          <h3>R$ ${myJson[index].preco}</h3>
        </div>
        <div class="button">
          <input type="button" id="button" value="Adicionar ao carrinho">
        </div>
      </div>`
    }
  }

  botoes = document.querySelectorAll('#button')
}

let idx = 1;
botoes.forEach(botao => {
  botao.addEventListener('click', PatchProdutos(myJson[idx].id, myJson[idx].status, idx))
  idx++;
});

function PatchProdutos (id, status, idx){
  try {
    // await fetch(`http://localhost:5500/${id} ${status}`, {
    //   method: "PATCH",
    //   headers: {
    //       "Content-Type" : "application/json"
    //     },
    //   body: JSON.stringify(
    //     {
    //       id,
    //       link,
    //       status,
    //       descricao,
    //       preco,
    //     }
    //   )
    // });

    produtoAtualizado = {
      id: "porra louca",
      link: "./images/image01.png",
      status: true,
      descricao: "aaa 1",
      preco: "999 1",
    }

  } catch (error) {
    console.log(error)
  }

  if (idx === myJson.length){
    idx = 1;
    return;
  }
}