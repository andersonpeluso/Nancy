# NancyFX
Um framework leve, feito para construir aplicações web para .net e mono. A proposta do Nancy é simplificar e agilizar o desenvolvimento, diminuindo a quantidade de configurações, e isso é feito através de padrões e convenções, possibilitando a criação de sites em pouquíssimo tempo. Desenvolvido para não ter dependências de outros frameworks. Além disso, o Nancy trabalha com o conceito de hosts, isso significa que o Nancy pode rodar com ASP.NET, WCF, OWIN ou integrado a qualquer aplicação. As implementações desses hosts não são distribuídas em conjunto com o framework core do Nancy. Essas implementações são distribuídas de forma separada, permitindo que você utilize apenas a que desejar, e tenha liberdade de escolher a que preferir.

Nancy suporta requisições GET, POST, PUT, DELETE, HEAD, OPTIONS e PATCH e oferece uma linguagem DSL simples e elegante. Além disso, Nancy é criado pela comunidade e tem seu código open-source. O código está disponível no GitHub: https://github.com/NancyFx.

**O que é Nancy?**
Nancy é uma estrutura leve para criar sites / serviços sem interferir no seu caminho. É fortemente inspirado por um projeto Ruby chamado Sinatra, que se identifica como não sendo uma estrutura, uma vez que não inclui todo o encanamento de coisas como um ORM, muita configuração etc.


**Resolução Automática de Dependências**
Nancy fornece um contêiner IOC incorporado chamado TinyIOC, que encontrará todas as suas dependências automaticamente para você ou se você quiser / precisar configurar algo, poderá fazê-lo em vários pontos do seu aplicativo. Isso é feito em uma classe Bootstrapper que expõe vários métodos e propriedades para permitir a configuração do Nancy.


**Teste mais fácil**
Fornece uma biblioteca de testes que permite testar o ciclo completo de solicitação / resposta, para não apenas testar se sua solicitação retorna o modelo que você espera, como também para testar quando, ao passar cabeçalhos de aceitação, a resposta está no formato que você deseja


**Sem configuração**
Para colocar o Nancy em funcionamento, não é necessária nenhuma configuração, nenhum arquivo XML desagradável para modificar, nada. Como seu host independente, você não precisa modificar nada no web.config para executá-lo via IIS, por exemplo.


**Negociação de Conteúdo**
A Negociação de Conteúdo é incorporada ao Nancy e é executada imediatamente. Isso significa que o Nancy pode ser usado em um aplicativo do tipo API e em um aplicativo de site. De fato, se você quisesse, poderia fazer as duas coisas com muita facilidade.

**Resumo**
Uma abordagem diferente para definir "rotas" usando lambdas para identificar caminhos relativos, argumentos e a implementação da resposta.
