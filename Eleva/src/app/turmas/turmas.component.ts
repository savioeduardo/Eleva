import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Turma } from '../models/Turma';
import { TurmaService } from './turma.service';
import { Escola } from '../models/Escola';

@Component({
  selector: 'app-turmas',
  templateUrl: './turmas.component.html',
  styleUrls: ['./turmas.component.css']
})
export class TurmasComponent implements OnInit {

  public turmas: Turma[];
  public turmaSelect: Turma | undefined;
  public turmaForm: FormGroup  = this.fb.group({
    id: [''],
    codigo: [''],
    escolaId: new Escola()
  });
  public titulo = "Turmas";
  public escolas: Escola[];

  constructor(private fb: FormBuilder,
    private turmaService: TurmaService) {
    this.turmas = [];  
    this.escolas = [];  
  }

  ngOnInit() {
    this.carregarTurmas();
    this.carregarEscolas();
  }

  selecionarTurma(turma: Turma){
    this.turmaSelect = turma;
    this.turmaForm.patchValue(turma);
  }

  carregarTurmas(){
    this.turmaService.getAll().subscribe(data => {
      this.turmas = data;
    });
  }

  carregarEscolas(){
    this.turmaService.getEscolas().subscribe(data => {
      this.escolas = data;
      console.log(this.escolas);
    });
  }

  voltar(turmaSelect: Turma){
    this.turmaSelect = undefined; 
  }

  turmaSubmit(){
    this.salvarTurma(this.turmaForm.value);
  }

  apagarTurma(turma: Turma){
    this.turmaService.delete(turma).subscribe(
      data => {
        this.carregarTurmas(); 
      }
    );
  }

  cadastrar(){
    this.turmaSelect = new Turma();
    this.turmaForm.patchValue(this.turmaSelect);
  }

  getEscola(turma: Turma){
    console.log(turma.escolaId);
  }

  salvarTurma(turma: Turma){
    console.log(turma);
    if(turma.id === 0){
      this.turmaService.post(turma).subscribe(
        data => {
          this.carregarTurmas();
          this.turmaSelect = undefined; 
        }
      );
    }else{
      this.turmaService.put(turma).subscribe(
        data => {
          this.carregarTurmas();
          this.turmaSelect = undefined; 
        }
      );
    }
    
  }

}
