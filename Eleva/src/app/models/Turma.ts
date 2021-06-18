import { Escola } from "./Escola";

export class Turma {
    id: number;
    codigo: string;
    escola: Escola;
    escolaId: Escola;

    constructor() { 
        this.id = 0;
        this.codigo = "";
        this.escola = new Escola();
        this.escolaId = new Escola();
      }
}