![CO-9](https://github.com/user-attachments/assets/62cd5af8-c493-4076-bde8-8261e5433ca4)

## 🥁 CarnaCode 2026 - Desafio 21 - Strategy

Oi, eu sou o [seu nome aqui] e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Strategy** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)

## Problema
Um e-commerce precisa calcular frete usando diferentes transportadoras (Correios, FedEx, DHL, Transportadora Local), cada uma com sua própria lógica de cálculo.
O código atual usa condicionais para escolher o algoritmo, violando o Open/Closed Principle.

## Solução
O padrão Strategy foi aplicado para resolver os seguintes problemas:
*	✅ Como encapsular cada algoritmo de cálculo de frete em sua própria classe? - Cada transportadora implementa sua própria estratégia.
*	✅ Como tornar algoritmos intercambiáveis em tempo de execução? - O cliente pode escolher a estratégia desejada dinamicamente.
*	✅ Como adicionar novas transportadoras sem modificar código existente? - Basta criar uma nova classe de estratégia.
*	✅ Como testar cada algoritmo de forma isolada? - Cada estratégia pode ser testada independentemente.

### Estrutura do projeto
📂 src/StrategyChallenge/<br>
├── 📂 Entity/<br>
│
└── ShippingInfo.cs # Dados do frete<br>
├── 📂 Strategy/<br>
│
└── IShippingCalculatorStrategy.cs # Interface base para estratégias de cálculo<br>
├── 📂 ConcreteStrategy/<br>
│
├── CorreiosStrategy.cs # Estratégia para Correios<br>
│
├── FedexStrategy.cs # Estratégia para FedEx<br>
│
├── DhlStrategy.cs # Estratégia para DHL<br>
│
└── LocalStrategy.cs # Estratégia para Transportadora Local<br>
├── Challenge.cs # Documento explicativo do desafio (não faz parte da execução)<br>
└── Program.cs # Exemplos de uso do padrão

### Componentes
#### 1. Entity (ShippingInfo)
Classe que representa as informações necessárias para o cálculo do frete: origem, destino, peso e se é expresso.

#### 2. Strategy (IShippingCalculatorStrategy)
Interface que define as operações para cálculo de frete, prazo de entrega e disponibilidade.

#### 3. ConcreteStrategy (CorreiosStrategy, FedexStrategy, DhlStrategy, LocalStrategy)
Implementações concretas da interface para cada transportadora, encapsulando suas regras de negócio.

#### 4. Program.cs
Demonstra exemplos de uso das estratégias, mostrando como calcular frete e prazo para diferentes transportadoras.

### Tecnologias
•	.NET 8
•	C# 12
•	Design Pattern: Decorator

### Como Executar
1. Clone o repositório
2. Navegue até a pasta do projeto:
```bash
cd StrategyChallenge
```
3. Execute o projeto:
```bash
dotnet run
```

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).
