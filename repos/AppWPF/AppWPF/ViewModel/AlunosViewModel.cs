using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppWPF.Model;

namespace AppWPF.ViewModel
{
    public class AlunosViewModel : BaseNotifyPropertyChanged
    {
        public System.Collections.ObjectModel.ObservableCollection<Model.Aluno> Alunos { get; private set; }

        private Model.Aluno _AlunoSelecionado;
        public Model.Aluno AlunoSelecionado {
            get { return _AlunoSelecionado; }
            set {
                SetField(ref _AlunoSelecionado, value);
                Deletar.RaiseCanExecuteChanged();
                Editar.RaiseCanExecuteChanged();
            }
        }

        public AlunosViewModel() {
            Alunos = new System.Collections.ObjectModel.ObservableCollection<Model.Aluno>();
            Alunos.Add(new Model.Aluno() 
            {
                Id = 1,
                Nome = "Jailson",
                DataMatricula = new DateTime(2000, 10, 12),
                Sexo = "Masculino",
                EstadoCivil = Model.EstadoCivil.Solteiro,
                StatusMatricula = Model.StatusMatricula.Matriculado,
                DataNascimento = new DateTime(1990, 08, 21)
            });
        }

        public DeletarCommand Deletar { get; private set; } = new DeletarCommand();

        public class DeletarCommand : BaseCommand {
            public override bool CanExecute(object parameter) {
                var viewModel = parameter as AlunosViewModel;
                return viewModel != null && viewModel.AlunoSelecionado != null;
            }

            public override void Execute(object parameter) {
                var viewModel = (AlunosViewModel)parameter;
                viewModel.Alunos.Remove(viewModel.AlunoSelecionado);
                viewModel.AlunoSelecionado = viewModel.Alunos.FirstOrDefault();
            }
        }

        public EditarCommand Editar { get; private set; } = new EditarCommand();

        public class EditarCommand : BaseCommand 
        {
            public override bool CanExecute(object parameter) 
            {
                var viewModel = parameter as AlunosViewModel;
                return viewModel != null && viewModel.AlunoSelecionado != null;
            }

            public override void Execute(object parameter)
            {
                var viewModel = (AlunosViewModel)parameter;
                var cloneAlunos = (Model.Aluno)viewModel.AlunoSelecionado.Clone();
                var aw = new FormAlunos();
                aw.DataContext = cloneAlunos;
                aw.ShowDialog();

                if (aw.DialogResult.HasValue && aw.DialogResult.Value) {
                    viewModel.AlunoSelecionado.DataMatricula = cloneAlunos.DataMatricula;
                    viewModel.AlunoSelecionado.DataNascimento = cloneAlunos.DataNascimento;
                    viewModel.AlunoSelecionado.EstadoCivil = cloneAlunos.EstadoCivil;
                    viewModel.AlunoSelecionado.Nome = cloneAlunos.Nome;
                    viewModel.AlunoSelecionado.Sexo = cloneAlunos.Sexo;
                    viewModel.AlunoSelecionado.StatusMatricula = cloneAlunos.StatusMatricula;
                }

            }
        }

        public NovoCommand Novo { get; private set; } = new NovoCommand();

        public class NovoCommand : BaseCommand
        {
            public override bool CanExecute(object parameter) 
            { 
                return parameter is AlunosViewModel;  
            }

            public override void Execute(object parameter) 
            {
                var viewModel = (AlunosViewModel)parameter;
                var aluno = new Model.Aluno();
                var maxID = 0;
                if(viewModel.Alunos.Any()) {
                    maxID = viewModel.Alunos.Max(a => a.Id);
                }

                aluno.Id = maxID + 1;
                aluno.DataNascimento = DateTime.Now;
                aluno.DataMatricula = DateTime.Now;
                var aw = new FormAlunos();
                aw.DataContext = aluno;
                aw.ShowDialog();

                if(aw.DialogResult.HasValue && aw.DialogResult.Value) {
                    viewModel.Alunos.Add(aluno);
                    viewModel.AlunoSelecionado = aluno;
                }
            }
        }
    }
}