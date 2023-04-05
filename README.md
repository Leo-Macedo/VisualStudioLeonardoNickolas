# Descrição do Projeto
Projeito feito por Leonardo e Nickolas

# Menu
No menu, colocamos um "MenuStrip" para conseguirmos acessar os projetos e o botão "Sair" para finalizar a execução.

## Combustível (Form2)
### O que faz?
É um projeto onde a pessoa coloca o tipo de combustível e quantos litros colocou, e dependendo de cada item, tem um certo desconto.
### Como fizemos?
#### Design
Começamos adicionando 3 "labels", 3 "textbox" e 3 "buttons".<br>
Nas labels, pedimos o tipo de combustível, "a" para álcool e "g" para gasolina, quantos litros a pessoa colocou e o total a pagar.<br>
Nas textbox, é o lugar onde a pessoa vai colocar e sair a informação.<br>
#### Código
Nos botões, temos o "Calcular", que é onde acontece o processo. Adicionamos as variáveis, convertemos elas e usamos os comandos "if" e "else" para identificar o desconto.<br>
No "Voltar" (que será igual em todos os forms), é o botão para voltar ao menu.<br>
O "Limpar" limpa todas as textbox e volta para a primeira textbox.<br>

## Votação (Form3)
### O que faz?
Este é um projeto que simula uma votação, onde os votos são recebidos, contados e o resultado é impresso com: vencedor, total de votos e porcentagem do ganhador.
### Como fizemos?
#### Design
Uma label foi adicionada com instruções sobre como votar.<br>
Foram adicionadas duas textbox: uma para digitar o voto e outra para exibir o voto.<br>
#### Código
As variáveis foram declaradas como globais, permitindo que elas participem de todo o processo do formulário.<br>
Foram adicionados 4 botões: o "vote", que é utilizado para registrar o voto; nesse botão, utilizamos um "if" e "else" para identificar para quem foi o voto.<br>
O "encerrar" é utilizado para finalizar a votação e determinar o vencedor. Nesse botão, também utilizamos um "if" e "else" para saber quem foi o vencedor.<br>
O "limpar" serve para apagar o conteúdo das textbox e zerar as variáveis. Como as variáveis são globais, elas continuam com o valor que tinham antes.<br>
O botão "voltar" tem a mesma função do botão "voltar" do Form2.

# Tabuada (Form4)
## O que faz?
Este projeto realiza a tabuada de qualquer número, começando do 0 e terminando no 10. Foram utilizados 3 comandos de loop: "while", "for" e "do...while", todos realizando a mesma operação.
## Como Fizemos?
### Design
Foi adicionada uma label para perguntar qual o número que se deseja a tabuada e uma textbox para receber o número digitado.<br> Também foi adicionada outra label para mostrar o resultado. A textbox tem um scroll para baixo para exibir todos os resultados.
### Comando While
Este comando serve para repetir os comandos dentro dele enquanto a condição for verdadeira.
### Comando For
Este comando de looping também foi utilizado, onde a variável "i" tem seu valor definido na condição do for e é incrementada a cada repetição (no caso, somando 1).
### Comando Do...While
Este comando é um pouco diferente, pois ele repete os comandos dentro dele pelo menos uma vez e a condição vem ao final do comando. E a condição no final, funciona de forma similar ao comando while.

