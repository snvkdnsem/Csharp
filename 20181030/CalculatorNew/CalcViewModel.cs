using System;
using System.ComponentModel;
using System.Windows.Input;
namespace CalculatorNew
{
    public class CalcViewModel : INotifyPropertyChanged
    {
        //아래 두 필드는 속성으로 구현되어 있다.
        //출력될 문자들을 담아둘 변수
        string inputString = "";
        //계산기화면의 출력 텍스트박스에 대응되는 필드
        string displayText = "";
        //속성이 바뀔때 이벤트 발생하도록 이벤트 정의
        public event PropertyChangedEventHandler PropertyChanged;
        //생성자
        public CalcViewModel()
        {
            //이벤트 핸들러 정의
            //숫자 버튼을 클릭할 때 실행
            this.AddCharCommand = new AddCharCommand(this);
            //백스페이스 버튼을 클릭할 때 실행, 한글자 삭제
            this.DeleteCharCommand = new DeleteCharCommand(this);
            //Clear 버튼을 클릭할 때 실행, 출력창을 전부 지운다.
            this.ClearCommand = new ClearCommand(this);
            //+,-,*,/ 버튼을 클릭할 때 실행
            //현재출력창의 숫자를 Op1 속성에 저장, Op속성에 클릭한 연산자 저장
            //계산기의 출력화면을 Clear
            this.OperationCommand = new OperationCommand(this);
            // =버튼을 클릭시 실행
            this.CalcCommand = new CalcCommand(this);
        }
        // Public 속성들을 정의
        public string InputString
        {
            internal set
            {
                if (inputString != value)
                {
                    inputString = value;
                    OnPropertyChanged("InputString");
                    this.DisplayText = inputString;

                    //((DeleteCharCommand)this.DeleteCharCommand).OnCanExecuteChanged();
                }
            }
            get { return inputString; }
        }
        //계산기의 출력창과 바인딩된 속성
        public string DisplayText
        {
            protected set
            {
                if (displayText != value)
                {
                    displayText = value;
                    OnPropertyChanged("DisplayText");
                }
            }
            get { return displayText; }
        }
        public string Op { get; set; }
        public double Op1 { get; set; }
        public double Op2 { get; set; }
        // 숫자 클릭
        public ICommand AddCharCommand { protected set; get; }
        // <- 클릭, 한글자씩 삭제
        public ICommand DeleteCharCommand { protected set; get; }
        // C 클릭시 DisplayText 전체를 지운다.
        public ICommand ClearCommand { protected set; get; }
        // +, -, *, / 클릭
        public ICommand OperationCommand { protected set; get; }
        // = 클릭
        public ICommand CalcCommand { protected set; get; }
        protected void OnPropertyChanged(string propertyName)
        {
            //이벤트를 발생시킨다.
            if (PropertyChanged != null)
                PropertyChanged(this, new
               PropertyChangedEventArgs(propertyName));
        }
    }

    class AddCharCommand : ICommand
    {
        private CalcViewModel viewModel;
        public event EventHandler CanExecuteChanged;
        public AddCharCommand(CalcViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        // 1,2,,,, 숫자들을 눌렀을때 실행됨
        public void Execute(object parameter)
        {
            viewModel.InputString += parameter;
        }
    }
    class DeleteCharCommand : ICommand
    {
        private CalcViewModel viewModel;

        public DeleteCharCommand(CalcViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return viewModel.InputString.Length > 0;
        }
        // BACK 버튼을 눌렀을 때 실행됨
        public void Execute(object parameter)
        {
            viewModel.InputString = viewModel.InputString.Substring(0,
           viewModel.InputString.Length - 1);
        }
    }
    class ClearCommand : ICommand
    {
        private CalcViewModel viewModel;
        public ClearCommand(CalcViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return viewModel.InputString.Length > 0; ;
        }
        public void Execute(object parameter)
        {
            // Clear
            viewModel.InputString = "";
        }
    }
    class OperationCommand : ICommand
    {
        private CalcViewModel viewModel;
        public OperationCommand(CalcViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return viewModel.InputString.Length > 0;
        }
        public void Execute(object parameter)
        {
            viewModel.Op = parameter.ToString();
            viewModel.Op1 = Convert.ToDouble(viewModel.InputString);
            viewModel.InputString = "";
        }
    }
    class CalcCommand : ICommand
    {
        private CalcViewModel viewModel;
        public CalcCommand(CalcViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return (viewModel.Op1.ToString() != string.Empty
            && viewModel.Op2.ToString() != string.Empty);
        }
        public void Execute(object parameter)
        {
            viewModel.Op2 = Convert.ToDouble(viewModel.InputString);
            switch (viewModel.Op)
            {
                case "+":
                    viewModel.InputString = (viewModel.Op1 +
         viewModel.Op2).ToString(); break;
                case "-":
                    viewModel.InputString = (viewModel.Op1 -
         viewModel.Op2).ToString(); break;
                case "*":
                    viewModel.InputString = (viewModel.Op1 *
         viewModel.Op2).ToString(); break;
                case "/":
                    viewModel.InputString = (viewModel.Op1 /
         viewModel.Op2).ToString(); break;
            }
            viewModel.Op1 = Convert.ToDouble(viewModel.InputString);
        }
    }
}