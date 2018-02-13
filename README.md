﻿# Docker SandBox (v1.0)

Para executar você precisa de uma máquina Linux com o Docker instalado.

No terminal digite:

``` sh
sudo su
git clone https://github.com/rodboza/docker_sandbox.git
git checkout v1.0
cd docker_sandbox
./main.sh
```


# Desenho da Arquitetura:<p>
![Desenho da Arquitetura](https://raw.githubusercontent.com/rodboza/docker_sandbox/v1.0/arquitetura.png)
 
# Change log:<p>
| Versão | Descrição |
| ---    | :---      |
| v1.0 | Versão inicial, ao rodar o script Main.sh serão criados 4 containers, sendo três Sql Servers ligados com o AwaysOn e mais um que é uma aplicação Asp .Net core que faz acesso aos containers SQL.|


