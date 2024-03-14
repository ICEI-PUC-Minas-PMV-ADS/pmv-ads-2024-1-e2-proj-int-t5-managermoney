# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Mateus Sobral tem 25 anos, motorista de aplicativo e estudante de Administração. Gosta de se relacionar com as pessoas, solteiro, sem filhos e sonha trabalhar para a Administração Pública Federal. Muito meticuloso, sistemático e organizado com as suas coisas, busca saber se o tempo empenhado como motorista de aplicativo tem válido a pena para complementar a sua renda.

Kátia Souza tem 36 anos, pedagoga e motorista de aplicativo. Casada e com um filho de 03 anos, sempre busca boas alternativas para ganhar um dinheiro extra, já que o bem-estar da sua família é algo precioso. Gosta de controlar, administrar todos os detalhes da vida familiar e, sobretudo, aspectos financeiros. O tempo com a sua família é super valorizado e otimizar os gastos para ter mais tempo livre para seus familiares é uma das suas principais prioridades.

Livia Fonseca tem 32 anos, após ficar desempregada optou por alugar um veículo e ser motorista de aplicativo. Tem uma boa comunicação, casada e tem dois filhos, como começou a ser motorista de aplicativo faz pouco tempo, a mesmo precisa de auxílio com seus gastos e lucros para administrar melhor seu capital.

Pedro Rocha tem 46 anos, entregador de aplicativo. Desde muito novo, gostava de andar de moto e a maior parte do tempo está sob duas rodas. Tentou algumas profissões anteriormente, mas identificou-se com a profissão de entregador de aplicativo pela sua paixão por motos. Sonha em fazer viajens internacionais, mas, para isso, precisa de uma moto nova, mais potente. Separar parte dos seus ganhos para realizar seu sonho, tornou-se seu principal objetivo.

Sebastião Alves, 57 anos, aposentado e motorista de aplicativo. Viúvo, duas filhas e três lindos netos. Avô coruja, adora passar o final de semana com seus netos curtindo cada momento com eles. Contudo, durante a semana, estava muito ocioso e resolveu atuar como motorista de aplicativo. Identificou-se com a profissão por sua flexibilidade de horários e o dinheiro extra tem ajudado no complemento da aposentadoria, além disso, fica feliz em conhecer novas pessoas. Sua dedicação a profissão durante a semana chama atenção e saber se essas horas empenhadas têm sido bem remuneradas é importante para ele.  

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Mateus Sobral       | Controlar os ganhos e despesas.     | Saber verdadeiramente se o exercício da sua atividade está sendo rentável.|
|Kátia Souza         | Ter ciência dos ganhos por hora trabalhada.     | Trabalhar menos e otimizar seus ganhos, tendo assim mais tempo livre com a sua família.|
|Livia Fonseca  | Visualizar os ganhos e despesas por categoria.     | Saber se está auferindo lucro, já que tem um alto custo com o aluguel do carro.|
|Pedro Rocha    | Ter ciência dos gastos com manutenção do veículo.     | Quer trocar de moto e deseja uma moto nova e mais potente.|
|Sebastião Alves     | Ter ciência dos ganhos por kilometro rodado e por hora trabalhada.     | Otimizar seus ganhos para ter os finais de semana livre em família.|

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário se cadastre | ALTA | 
|RF-002| A aplicação deve permitir que o usuário faça login | ALTA | 
|RF-003| A aplicação deve permitir que o usuário edite o perfil | MÉDIA |
|RF-004| A aplicação deve permitir inserções de saídas e entradas | ALTA |
|RF-005| A aplicação deve permitir inserções de saídas que repetem de forma mensal ou semanal | BAIXA |
|RF-006| A aplicação deve permitir o download do relatório completo do mês | MÉDIA |
|RF-007| A aplicação deve permitir separar as saídas e entradas por categoria | BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 
|RNF-003| Usuário terá segurança em seu login, ao tentar se conectar com login ou senha errado não acessaram o site e terá retorno de erro | MÉDIA | 
|RNF-004| A aplicação deve estar em conformidade com a Lei Geral de Proteção de Dados (LGPD).| MÉDIA |

**Prioridade: Alta / Média / Baixa. 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
