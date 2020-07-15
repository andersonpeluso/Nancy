# NancyFX

uma abordagem diferente para definir "rotas" usando lambdas para identificar caminhos relativos, argumentos e a implementação da resposta. 


O que é Nancy?
Nancy é uma estrutura leve para criar sites / serviços sem interferir no seu caminho. É fortemente inspirado por um projeto Ruby chamado Sinatra, que se identifica como não sendo uma estrutura, uma vez que não inclui todo o encanamento de coisas como um ORM, muita configuração etc.


Resolução Automática de Dependências - Nancy fornece um contêiner IOC incorporado chamado TinyIOC, que encontrará todas as suas dependências automaticamente para você ou se você quiser / precisar configurar algo, poderá fazê-lo em vários pontos do seu aplicativo. Isso é feito em uma classe Bootstrapper que expõe vários métodos e propriedades para permitir a configuração do Nancy.


Teste mais fácil - Nancy fornece uma biblioteca de testes que permite testar o ciclo completo de solicitação / resposta, para não apenas testar se sua solicitação retorna o modelo que você espera, como também para testar quando, ao passar cabeçalhos de aceitação, a resposta está no formato que você deseja


Sem configuração - Para colocar o Nancy em funcionamento, não é necessária nenhuma configuração, nenhum arquivo XML desagradável para modificar, nada. Como seu host independente, você não precisa modificar nada no web.config para executá-lo via IIS, por exemplo.


Negociação de Conteúdo - A Negociação de Conteúdo é incorporada ao Nancy e é executada imediatamente. Isso significa que o Nancy pode ser usado em um aplicativo do tipo API e em um aplicativo de site. De fato, se você quisesse, poderia fazer as duas coisas com muita facilidade.
