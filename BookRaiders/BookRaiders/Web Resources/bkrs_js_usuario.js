function OnLoadUsuario() {

}

function verificarCpf(executionContext) {
    debugger;
    // Obtem o contexto do formulario para acessar os campos
    var formContext = executionContext.getFormContext();

    // Obtem o campo bkrz cpf e depois o valor contido nele
    var cpf = formContext.getAttribute("bkrs_cpf").getValue();

    if (cpf != null) {
        // Remove todos os caracteres que nao sejam numeros
        cpf = cpf.replace(/\D/g, '');

        // Id da notificacao de erro
        var notifId = "incorrectcpf";

        if (cpf.length != 11) {
            // Obtem o controle do campo bkrz_cpf e adiciona uma notificacao com o texto e id
            formContext.getControl("bkrs_cpf").setNotification("Formato incorreto. Campo deve conter 11 numeros", notifId);
            return;
        }

        // Obtem o controle do campo bkrz_cpf e remove uma notificacao com id
        formContext.getControl("bkrs_cpf").clearNotification(notifId);

        cpf = formatarCpf(cpf);

        // Obtem o campo bkrz cpf e altera o valor contido nele
        formContext.getAttribute("bkrs_cpf").setValue(cpf);
    }
}

function formatarCpf(stringCpf) {
    return stringCpf.substring(0, 3) + "." + stringCpf.substring(3, 6) + "." + stringCpf.substring(6, 9) + "-" + stringCpf.substring(9, 11);
}