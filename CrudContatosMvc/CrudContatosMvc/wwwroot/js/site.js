
// Adicione referência à biblioteca jQuery no seu HTML
// <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

function pegarAtributo(e) {
    let usuarioId = e.getAttribute('data-usuario-id');
    const endpoint = `/Usuario/ListarContatosPorUsuarioId/${usuarioId}`;

    // Requisição ajax com fetch api do JavaScript
    fetch(endpoint, {
        method: 'GET',
    }).then((response) => {
        return response.text();
    }).then((data) => {
        // Use o ID para obter o elemento modal
        let modalId = 'staticBackdrop';
        let modalElement = document.getElementById(modalId);
        let divModal = modalElement.querySelector('.modal-body');

        // Atualize o conteúdo do modal com os dados retornados
        divModal.innerHTML = data;

        // Exiba o modal
        let bsModal = new bootstrap.Modal(modalElement);
        bsModal.show();  // Use show()

        getDatatable('#table-contatos-usuario');

        modalElement.addEventListener('hidden.bs.modal', () => {
            // Evento acionado após o modal ser oculto
            let modalBackdrop = document.querySelector('.modal-backdrop');
            if (modalBackdrop) {
                modalBackdrop.remove();
            }
        });

    }).catch((error) => {
        console.log(error);
    });
}

function getDatatable(id) {
    $(id).DataTable({
        "ordering": true,
        "paging": true,
        "searching": true,
        "oLanguage": {
            "sEmptyTable": "Nenhum registro encontrado na tabela",
            "sInfo": "Mostrar _START_ at&eacute; _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrar 0 at&eacute; 0 de 0 Registros",
            "sInfoFiltered": "(Filtrar de _MAX_ total registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Mostrar _MENU_ registros por pagina",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginate": {
                "sNext": "Proximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Ultimo"
            },
            "oAria": {
                "sSortAscending": ": Ordenar colunas de forma ascendente",
                "sSortDescending": ": Ordenar colunas de forma descendente"
            }
        }
    });
}

const alertClose = document.querySelector('.close-alert');

alertClose.addEventListener('click', () => {
    setTimeout(() => {
    document.querySelector('.alert').style.display = 'none';
    }, 100)
});

function mostrarSenha() {
    let inputPass = document.getElementById('senha');
    let btnShowPass = document.getElementById('btn-senha');

    if (inputPass.type === 'password') {
        inputPass.setAttribute('type', 'text');
        btnShowPass.src = './images/eye.png';
    } else {
        inputPass.setAttribute('type', 'password');
        btnShowPass.src = './images/eye_hide.png';
    }
}


function mascaraCelular() {
    let celular = document.getElementById('celular');
    let valor = celular.value.replace(/\D/g, ''); // Remove caracteres não numéricos

    if (valor.length <= 10) {
        celular.value = valor.replace(/(\d{2})(\d{4})(\d{4})/, '($1)$2-$3');
    } else {
        celular.value = valor.replace(/(\d{2})(\d{5})(\d{4})/, '($1)$2-$3');
    }
}

function mascaraCpfCnpj() {
    let documento = document.getElementById('cpfCnpj');
    let valor = documento.value.replace(/\D/g, ''); // Remove caracteres não numéricos

    if (valor.length <= 11) {
        // Aplica máscara de CPF
        documento.value = valor.replace(/(\d{3})(\d{3})(\d{3})(\d{2})/, '$1.$2.$3-$4');
    } else {
        // Aplica máscara de CNPJ
        documento.value = valor.replace(/(\d{2})(\d{3})(\d{3})(\d{4})(\d{2})/, '$1.$2.$3/$4-$5');
    }
}



