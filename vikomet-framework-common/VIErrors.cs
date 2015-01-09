using VIKomet.Framework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.Framework.Common
{
    public enum VIErrors
    {

        [ReadableStringAttribute("Não Autorizado.")]
        NAO_AUTORIZADO = 401,
        [ReadableString("Permissão insuficiente.")]
        PERMISSAO_INSUFICIENTE = 403,

        [ReadableStringAttribute("Ocorreu um erro ao processar os parametros de busca")]
        //[ReadableStringAttribute("Ocorreu um erro ao processar os parametros de busca", "en-US")]
        ERRO_AO_PROCESSAR_PARAMETROS_DE_BUSCA = 4001,
        [ReadableStringAttribute("Método de autenticação inválido")] 
        ERRO_AO_INFORMAR_CABECALHOS_HTTP_AUTHORIZATION = 4002,
        [ReadableStringAttribute("Ocorreu um erro ao processar os parametros de atualização")] 
        ERRO_AO_PROCESSAR_PARAMETROS_DE_ATUALIZACAO = 4003,
        
        [ReadableStringAttribute("O campo 'Título' deve ser preenchido")]
        ERRO_CAMPO_TITULO_VAZIO = 4004,
        [ReadableStringAttribute("O campo 'Url Amigável' deve ser preenchido")]
        ERRO_CAMPO_URLAMIGAVEL_VAZIO = 4005,
        [ReadableStringAttribute("O campo 'Descrição' deve ser preenchido")]
        ERRO_CAMPO_DESCRICAO_VAZIO = 4006,
        
        [ReadableStringAttribute("O campo 'Quantidade' deve ser preenchido.")]
        ERRO_CAMPO_QUANTIDADE_MENOR_IGUAL_A_ZERO = 4007,
        [ReadableStringAttribute("O campo 'SkuId' deve ser preenchido.")]
        ERRO_CAMPO_SKUID_VAZIO = 4008,
        [ReadableString("O campo 'Name' deve ser preenchido.")]
        ERRO_CAMPO_NAME_VAZIO = 4009,
        [ReadableString("O campo 'Link' deve ser preenchido.")]
        ERRO_CAMPO_LINK_VAZIO = 4010,
        [ReadableString("O campo 'Conteúdo' deve ser preenchido.")]
        ERRO_CAMPO_CONTEUDO_VAZIO = 4011,



        [ReadableString("Este conteúdo não pode ser excluído.")]
        ERRO_CONTEUDO_NAO_PODE_SER_EXCLUIDO = 4012,
        [ReadableString("Menu não encontrado!")]
        ERRO_MENU_NAO_ENCONTRADO = 4013,
        [ReadableString("Senha inválida.")]
        ERRO_SENHA_INVALIDA = 4014,
        [ReadableString("Usuário inválido.")]
        ERRO_USUARIO_INVALIDO = 4015,
        [ReadableString("Email inválido.")]
        ERRO_EMAIL_INVALIDO = 4016,
        [ReadableString("Usuário e/ou Senha inválidos.")]
        ERRO_USUARIO_OU_SENHA_INVALIDO = 4017,
        [ReadableString("Nome e/ou Sobrenome não preenchidos.")]
        ERRO_NOME_SOBRENOME_NAO_PREENCHIDOS = 4018,
        [ReadableString("O Sexo informado é invalido.")]
        ERRO_SEXO_INVALIDO = 4019,
        [ReadableString("Já existe um usuário cadastrado com este username.")]
        ERRO_USUARIO_JA_CADASTRADO = 4020,
        [ReadableString("Já existe um usuario cadastrado com este email.")]
        ERRO_EMAIL_JA_CADASTRADO = 4021,
        [ReadableString("OwnerId não informado na busca.")]
        ERRO_OWNERID_NAO_INFORMADO_NA_BUSCA = 4022,
        
        [ReadableString("CPF ou CNPJ do titular do cartão não informado.")]
        ERRO_CPF_CNPJ_NAO_INFORMADO = 4024,
        [ReadableString("Já existe um ItemType cadastrado com este nome.")]
        ERRO_ITEMTYPE_JA_CADASTRADO = 4025,
        [ReadableString("não criado(a)/alterado(a) pois sua URL amigável já estava em uso.")]
        ERRO_URL_AMIGAVEL_EM_USO = 4026,
        [ReadableString("O campo 'Endereço' deve ser preenchido.")]
        ERRO_CAMPO_ENDERECO_VAZIO = 4027,
        [ReadableString("O campo 'Complemento' deve ser preenchido.")]
        ERRO_CAMPO_COMPLEMENTO_VAZIO = 4028,
        [ReadableString("O campo 'CEP' deve ser preenchido.")]
        ERRO_CAMPO_CEP_VAZIO = 4029,
        [ReadableString("O campo 'Bairro' deve ser preenchido.")]
        ERRO_CAMPO_BAIRRO_VAZIO = 4030,
        [ReadableString("O campo 'Cidade' deve ser preenchido.")]
        ERRO_CAMPO_CIDADE_VAZIO = 4031,
        [ReadableString("O campo 'Estado' deve ser preenchido.")]
        ERRO_CAMPO_ESTADO_VAZIO = 4032,
        [ReadableString("Tipo de endereço inválido")]
        ERRO_ENDERECO_INVALIDO = 4033,
        [ReadableString("Esta categoria não pode ser excluída.")]
        ERRO_CATEGORIA_NAO_PODE_SER_EXCLUIDA = 4034,
        [ReadableString("Conteúdo não encontrado.")]
        ERRO_CONTEUDO_NAO_ENCONTRADO = 4035,
        [ReadableString("Evento não encontrado")]
        ERRO_EVENTO_NAO_ENCONTRADO = 4036,
        [ReadableString("Nova senha inválida.")]
        ERRO_NOVA_SENHA_INVALIDA = 4037,

        //Calculo de frete FreightService
        [ReadableString("Erro ao calcular frete: comprimento total igual a zero.")]
        ERRO_FRETE_COMPRIMENTO_IGUAL_A_ZERO = 4038,
        [ReadableString("Erro ao calcular frete: largura total igual a zero.")]
        ERRO_FRETE_LARGURA_IGUAL_A_ZERO = 4039,
        [ReadableString("Erro ao calcular frete: altura total igual a zero.")]
        ERRO_FRETE_ALTURA_IGUAL_A_ZERO = 4040,
        [ReadableString("Erro ao calcular frete: peso total igual a zero.")]
        ERRO_FRETE_PESO_IGUAL_A_ZERO = 4041,
        [ReadableString("Erro ao calcular frete: preço total igual a zero.")]
        ERRO_FRETE_PRECO_IGUAL_A_ZERO = 4042,
        [ReadableString("Dados do destinatário não preenchidos.")]
        ERRO_DESTINATARIO_NAO_PREENCHIDO = 4043,

        [ReadableString("Data de vigência da recorrência inválida. Data deve ser maior que o dia atual somado ao intervalo de recorrência escolhido.")]
        ERRO_VIGENCIA_DA_RECORRENCIA_INVALIDA = 4044,

        [ReadableString("Esta operação requer o uso de uma conexão segura (HTTPS).")]
        ERRO_OPERACAO_REQUER_HTTPS = 4045,
        [ReadableString("O campo 'Username' deve ser preenchido.")]
        ERRO_CAMPO_USERNAME_VAZIO = 4046,        

        [ReadableStringAttribute("Message Gateway não encontrado.")]
        ERRO_MESSAGE_GATEWAY_NAO_ENCONTRADO = 4047,

        [ReadableStringAttribute("Subscription não encontrada.")]
        ERRO_SUBSCRIPTION_NAO_ENCONTRADA = 4048,

        [ReadableStringAttribute("Subscriber não encontrado.")]
        ERRO_SUBSCRIBER_NAO_ENCONTRADO = 4047,
        
        [ReadableString("Produto não encontrado.")]
        ERRO_URL_AMIGAVEL_PRODUTO_NAO_ENCONTRADO = 4048,

        [ReadableString("Kit não encontrado.")]
        ERRO_URL_AMIGAVEL_KIT_NAO_ENCONTRADO = 4049,

        [ReadableString("Coleção não encontrada.")]
        ERRO_URL_AMIGAVEL_COLECAO_NAO_ENCONTRADA = 4050,

        [ReadableString("Categoria não encontrada.")]
        ERRO_URL_AMIGAVEL_CATEGORIA_NAO_ENCONTRADO = 4051,

        [ReadableString("Menu não encontrado.")]
        ERRO_URL_AMIGAVEL_MENU_NAO_ENCONTRADO = 4052,

        [ReadableString("Marca não encontrada.")]
        ERRO_URL_AMIGAVEL_MARCA_NAO_ENCONTRADO = 4053,

        [ReadableString("Conteúdo não encontrado.")]
        ERRO_URL_AMIGAVEL_CONTEUDO_NAO_ENCONTRADO = 4054,
        
        [ReadableString("Categoria de conteúdo não encontrada.")]
        ERRO_URL_AMIGAVEL_CATEGORIA_DE_CONTEUDO_NAO_ENCONTRADO = 4055,
        
        [ReadableString("Item não encontrado.")]
        ERRO_URL_AMIGAVEL_ITEM_NAO_ENCONTRADO = 4056,
        
        [ReadableString("Message Gateway não encontrado.")]
        ERRO_URL_AMIGAVEL_MESSAGE_GATEWAY_NAO_ENCONTRADO = 4057,
        
        [ReadableString("Subscription não encontrado.")]
        ERRO_URL_AMIGAVEL_SUBSCRIPTION_NAO_ENCONTRADO = 4058,

        //Freight Table
        [ReadableStringAttribute("O campo 'Carrier Id' deve ser selecionado")]
        ERRO_CAMPO_CARRIERID_VAZIO = 4059,
        [ReadableStringAttribute("O campo 'DateFrom' deve ser preenchido")]
        ERRO_CAMPO_DATEFROM_VAZIO = 4060,
        [ReadableStringAttribute("O campo 'DateTo' deve ser preenchido")]
        ERRO_CAMPO_DATETO_VAZIO = 4061,
        [ReadableStringAttribute("O campo 'Cubed Weight Factor' deve ser preenchido")]
        ERRO_CAMPO_CUBEDWEIGHTFACTOR_VAZIO = 4062,

        [ReadableString("Valor de searchable, caso informado, deve ser 'true', 'false' ou 'all'.")]
        ERRO_AO_PARSEAR_VALOR_SEARCHABLE = 4063,

        [ReadableString("Extended property não encontrada no template do item.")]
        ERRO_EXTENDED_PROPERTY_NAO_ENCONTRADA_NO_ITEMTYPE = 4064,

        [ReadableString("Extended property incompatível com a definição do template do item.")]
        ERRO_EXTENDED_PROPERTY_INCOMPATIVEL_COM_ITEMTYPE = 4065,
        [ReadableString("Extended property obrigatória não preenchida.")]
        ERRO_EXTENDED_PROPERTY_OBRIGATORIA_NAO_PREENCHIDA= 4066,

        
        [ReadableStringAttribute("Um pagamento deve estar associado a uma conta de usuário do VI Komet.")]
        ERRO_AO_CRIAR_PAGAMENTO_SEM_CONTA_DE_USUARIO_DA_PLATAFORMA = 5001,
        [ReadableStringAttribute("Um pagamento deve estar associado a um pedido.")]
        ERRO_AO_CRIAR_PAGAMENTO_SEM_PEDIDO = 5002,
        [ReadableStringAttribute("Um pagamento deve estar associado a um usuário.")]
        ERRO_AO_CRIAR_PAGAMENTO_SEM_USER = 5003,
        [ReadableStringAttribute("Token do Moip não encontrado.")]
        TOKEN_MOIP_NAO_ENCONTRADO = 5004,
        [ReadableStringAttribute("Key do Moip não encontrado.")]
        KEY_MOIP_NAO_ENCONTRADO = 5005,
        [ReadableStringAttribute("Url do ambiente do Moip não encontrado.")]
        ENV_URL_MOIP_NAO_ENCONTRADO = 5006,
        [ReadableStringAttribute("Valor do pagamento deve ser informado.")]
        VALOR_PAGAMENTO_NAO_ENCONTRADO = 5007,
        [ReadableStringAttribute("Razão do pagamento deve ser informado.")]
        RAZAO_PAGAMENTO_NAO_ENCONTRADO = 5008,
        

        [ReadableStringAttribute("Ocorreu um erro ao registrar o usuário.")]
        ERRO_AO_REGISTRAR_USUARIO = 5009,

        [ReadableString("Operação inválida para estas configurações.")]
        ERRO_OPERACAO_INVALIDA_PARA_ESTA_CONTA_DA_PLATAFORMA = 5010,

        [ReadableString("Erro ao retornar a Extended Property.")]
        ERRO_AO_RETORNAR_EXTENDED_PROPERTY = 5011,

        [ReadableString("Erro ao armazenar a Extended Property.")]
        ERRO_AO_ARMAZENAR_EXTENDED_PROPERTY = 5012,

        

        

        [ReadableString("Estoque não encontrado.")]
        ERRO_ESTOQUE_NAO_ENCONTRADO = 5014,

        [ReadableString("Reserva não encontrada.")]
        ERRO_RESERVA_NAO_ENCONTRADA = 5015,

        [ReadableString("Compra não encontrada.")]
        ERRO_COMPRA_NAO_ENCONTRADA = 5016,

        [ReadableString("Usuário não encontrado.")]
        ERRO_USUARIO_NAO_ENCONTRADO = 5017,

        [ReadableString("Nenhuma configuração de frete encontrada.")]
        ERRO_FRETE_NAO_ENCONTRADO = 5018,

        [ReadableString("Tipo de produto inválido.")]
        ERRO_PRODUCT_TYPE_INVALIDO = 5019,

        [ReadableString("Erro ao converter Extended Property.")]
        ERRO_AO_CONVERTER_EXTENDED_PROPERTY = 5020,

        [ReadableString("Já existe um domínio cadastrado com este nome.")]
        ERRO_DOMINIO_JA_EXISTENTE = 5021,
        [ReadableString("Produto sem estoque disponível na quantidade desejada.")]
        ERRO_ESTOQUE_INSUFICIENTE = 5022,
        [ReadableString("Produto sem estoque disponível.")]
        ERRO_ESTOQUE_INDISPONIVEL= 5023,
        [ReadableString("Pedido não encontrado.")]
        ERRO_PEDIDO_NAO_ENCONTRADO = 5024,
        [ReadableString("Produto não encontrado.")]
        ERRO_PRODUTO_NAO_ENCONTRADO = 5025,
        [ReadableString("Linha do carrinho não encontrada.")]
        ERRO_LINHA_CARRINHO_NAO_ENCONTRADA = 5026,
        [ReadableString("Produto não vendável.")]
        ERRO_PRODUTO_NAO_VENDAVEL = 5027,
        [ReadableString("Quantidade a comprar deve ser maior que zero.")]
        ERRO_QUANTIDADE_MENOR_QUE_ZERO = 5028,

        [ReadableString("Menu não aprovado.")]
        ERRO_MENU_NAO_APROVADO = 5029,

        [ReadableStringAttribute("Ocorreu um erro ao atualizar o usuário.")]
        ERRO_AO_ALTERAR_USUARIO = 5030,

        [ReadableStringAttribute("Carrinho não encontrado.")]
        CARRINHO_NAO_ENCONTRADO = 5031,

        [ReadableString("Periodicidade não permitida para o produto.")]
        PERIODICIDADE_NAO_PERMITIDA_PARA_O_PRODUTO = 5032,

        [ReadableString("Erro ao processar pagamento no Moip.")]
        ERRO_AO_PROCESSAR_PAGAMENTO_NO_MOIP = 5033,

        [ReadableStringAttribute("Erro desconhecido.")]
        ERRO_DESCONHECIDO = 5100
        
        
    }
}
