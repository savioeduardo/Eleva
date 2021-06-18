import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Escola } from '../models/Escola';
import { Turma } from '../models/Turma';
import { EscolaService } from './escola.service';

@Component({
  selector: 'app-escolas',
  templateUrl: './escolas.component.html',
  styleUrls: ['./escolas.component.css']
})
export class EscolasComponent implements OnInit {

  public escolas: Escola[];
  public escolaSelect: Escola | undefined;
  public escolaForm: FormGroup  = this.fb.group({
    id: [''],
    nome: [''],
    endereco: [''],
    cidade: [''],
    estado: [''],
    telefone: ['']
  });
  public titulo = "Escolas";
  public turmasEscola: Turma[];

  public estados = [
    {"nome": "AC"},
    {"nome": "AL"},
    {"nome": "AP"},
    {"nome": "AM"},
    {"nome": "BA"},
    {"nome": "CE"},
    {"nome": "DF"},
    {"nome": "ES"},
    {"nome": "GO"},
    {"nome": "MA"},
    {"nome": "MT"},
    {"nome": "MS"},
    {"nome": "MG"},
    {"nome": "PA"},
    {"nome": "PB"},
    {"nome": "PR"},
    {"nome": "PE"},
    {"nome": "PI"},
    {"nome": "de"},
    {"nome": "RN"},
    {"nome": "RS"},
    {"nome": "RO"},
    {"nome": "RR"},
    {"nome": "SC"},
    {"nome": "SP"},
    {"nome": "SE"},
    {"nome": "TO"}];

  constructor(private fb: FormBuilder,
    private escolaService: EscolaService) {
    this.escolas = [];  
    this.turmasEscola = [];
  }

  ngOnInit() {
    this.carregarEscolas();
  }

  cadastrar(){
    this.escolaSelect = new Escola();
    this.escolaForm.patchValue(this.escolaSelect);
  }

  selecionarEscola(escola: Escola){
    this.escolaSelect = escola;
    this.turmasEscola = [];
    this.carregarTurmasPorEscola(escola);
    this.escolaForm.patchValue(escola);
  }

  carregarEscolas(){
    this.escolaService.getAll().subscribe(data => {
      this.escolas = data;
    });
  }

  carregarTurmasPorEscola(escola: Escola){
    this.escolaService.getTurmasPorEscola(escola).subscribe(data => {
      this.turmasEscola = data;
      console.log(this.turmasEscola);
    });
  }

  voltar(escolaSelect: Escola){
    this.escolaSelect = undefined; 
  }

  escolaSubmit(){
    this.salvarEscola(this.escolaForm.value);
  }

  apagarEscola(escola: Escola){
    this.escolaService.delete(escola).subscribe(
      data => {
        this.carregarEscolas(); 
      }
    );
  }

  salvarEscola(escola: Escola){
    if(escola.id === 0){
      this.escolaService.post(escola).subscribe(
        data => {
          this.carregarEscolas();
          this.escolaSelect = undefined; 
        }
      );
    }else{
      this.escolaService.put(escola).subscribe(
        data => {
          this.carregarEscolas();
          this.escolaSelect = undefined; 
        }
      );
    }
    
  }

}
