# Aplicativo Android com Realidade Aumentada para o auxílio à navegação na Biblioteca da Universidade Federal de Roraima

**Anny Caroline Walker Silva, Pedro Aleph Gomes de Souza Vasconcelos**

Departamento de Ciência da Computação - Universidade Federal de Roraima (UFRR)
Boa Vista, RR - Brasil
annyufrr@gmail.com, pedro.aleph.allen@gmail.com

**_Abstract._** _The UFRR’s library have a huge collection of books willing in their
shelves. Thinking about this, this article rises as a form to develop an Android
application using Augmented Reality as a tool capable of auxiliate a user’s
navigation through the space corresponding to the library._

**_Resumo._** _Tendo a Biblioteca da UFRR grande acervo de livros dispostos em suas
prateleiras, este artigo foi pensado de forma a desenvolver uma aplicação
Android que utiliza a Realidade Aumentada como ferramenta para auxiliar a
navegação de um usuário pelo espaço correspondente à biblioteca._

## 1. Introdução

A Realidade Aumentada (RA) enquanto ferramenta pode ser utilizada para solucionar
uma série de problemas do dia a dia humano e ainda oferecer informações extras aos
usuários sobre determinada aspecto do mundo a partir de uma tela com elementos
digitais (KREVELEN e POELMAN, 2010). Considerando o leque de soluções que a
RA oferece, foi observado uma problemática no campus Paricanara da UFRR que com
auxílio de RA pode ser otimizado e melhorado.
A problemática identificada é a navegação indoor (dentro) da biblioteca, que no
presente momento é feita através de códigos dispostos pelas prateleiras, fazendo com
que o usuário tenha que verificar prateleira por prateleira até encontrar o código
desejado, o que dificulta é a falta de visualização de uma prévia da direção em que se
encontra a prateleira desejada.
A solução sugerida é um aplicativo (app) de RA que aponta, a partir de setas
virtuais dispostas em prateleiras através de marcadores, a direção procurada e leva o
usuário direto até lá, sem possibilidade de erros e sem a necessidade de buscar por
códigos.
Para Peddie (2017), marcadores de RA são a forma mais comum e fácil de se
projetar objetos gráficos no mundo real, por isso esse foi o método escolhido. Esses
marcadores (como na Figura 1) são tipicamente quadrados brancos e pretos com
padrões codificados que identificam onde e qual objeto computadorizado deve aparecer
ali.


```
Figura 1. Exemplo de marcador utilizado nesse app.
```
## 2. Objetivo

Sendo guiado pelo aplicativo, o estudante é direcionado para área de conhecimento,
subárea de conhecimento e até mesmo livro desejado através de um filtro de pesquisa, e
como informação extra, o app contém estatísticas que convém para o tipo de pesquisa
realizada, que no futuro será partir de coleta de dados de quem já o utilizou.
De formal geral o aplicativo tem como objetivo facilitar o máximo possível os
procedimentos que o estudante usa para navegar na biblioteca.
E como objetivos específicos temos que:

1. Facilitar busca por área de conhecimento na biblioteca;
2. Facilitar busca por subárea de conhecimento na biblioteca;
3. Facilitar busca por livro na biblioteca;
4. Mostrar estatísticas de subáreas mais pesquisadas;
5. Mostrar estatística de livros mais pesquisados;
6. E finalmente, mostrar estatística de quantas vezes o livro foi pesquisado.

## 3. Justificativa

A procura de um livro pode ser trabalhosa, apesar de uns serem fáceis, outros nem tanto,
tendo em vista que a biblioteca é dividida em áreas de estudo, e sem detalhes a mais, e
também há o possibilidade do livro não se encontrar em nenhum lugar, por todos do
mesmo já terem sido emprestados, ou por simplesmente não estarem no acervo da
biblioteca.
O aplicativo tenta através da RA otimizar o processo de busca igualmente para
todos os livros, além de contém o registro de cada livro, possibilitando assim que no
futuro, antes mesmo de iniciar a busca, seja possível verificar se determinado livro há na
biblioteca, e se está disponível para empréstimo.
Outra justificativa é a amenização de poluição visual da biblioteca, que devido
ao atual sistema de organização enche as prateleiras de papéis com códigos,
problemática essa que é facilmente resolvida com o uso de apenas um código, o
marcador do app de RA construído a partir desse artigo.


Além de que com uma aplicação RA muito mais informações e dados úteis
podem ser dispostas aos usuário através do uso de um só código, o marcador.

## 4. Implementação

A implementação do app seguiu uma série de etapas que tornou possível o resultado
final, são essas etapas:
**4.1. Escolha das ferramentas**
A escolha das ferramentas se deu a partir da facilidade de implementação e
familiarização dos desenvolvedores. As ferramentas escolhidas foram:
Unity como motor de jogo, a linguagem C# devido ao seu grande poder e
Vuforia como biblioteca de RA por causa da facilidade de implementação dessa
tecnologia junto ao Unity.
E finalmente, para geração dos marcadores, foi utilizado o CorelDraw X8, tendo
em vista a facilidade de movimentar e ajustar vetores.
**4.2. Caso de uso**
A interface do sistema foi desenvolvida de forma simplificada e bastante intuitiva, onde
o usuário leva seu celular a um marcador, este sendo detectado pela câmera mostra os
tipos de pesquisa disponíveis, o usuário então escolhe a pesquisa desejada e logo em
seguida é guiado até seu objetivo através das setas que aparecem nos marcadores.
Chegando ao seu destino, o usuário aponta a câmera para o marcador e
estatísticas correspondente com sua pesquisa são mostradas na tela. Durante todo o
processo, o usuário tem a possibilidade de cancelar a pesquisa atual e iniciar outra ao
seu desejo.
**Figura 2. Caso de uso do sistema
4.3. Arquitetura do sistema**
A arquitetura foi implementada de acordo com a necessidade de corresponder ao caso
de uso do sistema. Dessa forma, todo marcador detectado (enquanto não houver
pesquisa selecionada) mostra a opção de selecionar pesquisa, após seleção de pesquisa,


todos os marcadores são configurados para atender aquela pesquisa, sendo possível
sempre cancelar a pesquisa atual e iniciar uma nova.
E ao chegar no resultado, o marcador correspondente ao objetivo final mostrará
as estatísticas da pesquisa selecionada. Para atender todos esses requisitos, a seguinte
arquitetura foi idealizada:
**Figura 3. Arquitetura do sistema
4.4. Sincronizando os marcadores**
Para tornar possível que todos os marcadores estejam sincronizados na direção do
objetivo ao ser realizada uma pesquisa, uma classe chamada Directions foi adicionada a
cada marcador. Essa classe possui um método público que possibilita a entrada de uma
direção se somente se uma nova pesquisa for realizada, sempre que isso acontece, é
selecionado do banco de dados os dados necessários correspondentes a pesquisa
escolhida, e para cada marcador existente é adicionado um valor de direção que segue a
seguinte lógica:
-1 para marcador que não possui direção ainda (nesse caso, a tela de pesquisa
aparece em todos os marcadores cuja direção seja -1),  1  para seta para cima é ativada,  2 
para seta para baixo é ativada,  3  para seta para esquerda é ativada e  4  para seta para a
direita é ativada, e finalmente 0 para marcador objetivo final.


**Figura 4. Direção das setas associadas a número**
Todos os marcadores começam na direção -1, ou seja, aparece a opção de
pesquisa para todos.  3  canvas (camada de interface) do Unity foram adicionados a cada
marcador, são eles: canvas de pesquisa, canvas de cancelar pesquisa e canvas de
chegada ao objetivo. A direção -1 ativa o canvas de pesquisa, a direção  0  ativa o canvas
de chegada no marcador, e todos, exceto direção -1, ativa o canvas de cancelar pesquisa.
**Figura 5. Canvas de pesquisa.
Figura 6. Canvas de chegada.**


```
Figura 7. Canvas de cancelar pesquisa.
```
## 5. Resultados

O teste da implementação atual, foi feito na área da computação que fica nas últimas
estantes de livros a direita da biblioteca da UFRR, a princípio houve problemas no apk
gerado, por isso foi realizado diretamente no console do unity. Este teste é apenas o
funcionamento geral do app na prática, para planos futuros ocorrerão para situações
mais específicas, e de real utilidade para os usuários, com suas opiniões.
O teste realizado pode ser visto no seguinte link:
https://drive.google.com/open?id=1griIUDUn85WUyvz_8y9WuOXlKA7ojVml
A simulação ocorreu como prevista, as setas demais marcadores guiando para a
estante desejada na direção correta, e o marcador da instante encontrada mostrando as
opções de especificação de livros da estante, ainda não foi possível demonstrar busca de
livros especificados pois ainda não há um banco de dados com informações dos livros.

## 6. Conclusão

Este trabalho atingiu sua finalidade inicial de utilizar RA como uma forma interativa
que o usuário faz com um objeto, especificamente para as estantes da Biblioteca Central
da UFRR, e futuramente, usando diretamente no livro, levando em conta suas próprias
informações contidas neste, mostrando algo adicional relevante para o estudante. Como
um protótipo inicial, ainda deixa muito a desejar, mas possui em teoria escrita todas as
funcionalidades desejadas, e o que deve ser feito para implementá-las, além de melhor
forma de usar RA como ao invés de utilizar marcadores, usa a localização do GPS, no
momento o app pode apenas ser usado para guiar o estudante para a estante onde o livro
procurado se encontra.


## Referências

KREVELEN, D.W.F van. POELMAN, R. A Survey of Augmented Reality
Technologies, Applications and Limitations, 2010. Disponível em: <
[http://kjcomps.6te.net/upload/paper1%20.pdf>.](http://kjcomps.6te.net/upload/paper1%20.pdf>.) Acesso em 11 de dezembro de 2017.
PEDDIE, Jon. Augmented Reality Where We Will All Live, 2017. Editora Springer.
