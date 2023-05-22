import { Personagem } from "./modules/personagem.js"
import { PersonagemView } from "./components/personagem-view.js"
import { Mago } from "./modules/mago.js"
import { Arqueiro } from "./modules/arqueiro.js"
import { ArqueiroMago } from "./modules/arqueiro-mago.js"
import { Guerreiro } from "./modules/guerreiro.js"

const magoAntonio = new Mago('Antonio', 4, 'fogo', 4, 3)
const magaJulia = new Mago('Julia', 8, 'gelo', 7, 10)
const arqueiroErick = new Arqueiro('Erick', 9, 9)
const arqueiroMagoChico = new ArqueiroMago('Chico', 7, 10, 'ar', 4, 8)
const settiGuerreiro = new Guerreiro('Setti', 6)

const personagens = [magoAntonio, magaJulia, arqueiroErick, arqueiroMagoChico, settiGuerreiro]

new PersonagemView(personagens).render()
