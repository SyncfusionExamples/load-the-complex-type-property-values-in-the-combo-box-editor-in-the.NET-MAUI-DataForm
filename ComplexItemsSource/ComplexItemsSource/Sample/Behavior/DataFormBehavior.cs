using Syncfusion.Maui.DataForm;

namespace ComplexItemsSource
{
    public class DataFormBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            if (dataForm != null )
            {
                dataForm.ItemsSourceProvider = new ItemSourceProvider();
                dataForm.RegisterEditor("Gender", DataFormEditorType.RadioGroup);
                dataForm.RegisterEditor("Address", DataFormEditorType.MultilineText);
                dataForm.RegisterEditor("Department", DataFormEditorType.ComboBox);
                dataForm.RegisterEditor("FeedBack", DataFormEditorType.MultilineText);
                dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
            }
        }
        private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem!= null)
            {
                if (e.DataFormItem != null && e.DataFormItem.FieldName == "Department" && e.DataFormItem is DataFormComboBoxItem comboBoxItem)
                {
                    comboBoxItem.DisplayMemberPath = "Name";
                    comboBoxItem.SelectedValuePath = "DepartmentID";
                }
            }
        }
        protected override void OnDetachingFrom(SfDataForm dataForm)
        {
            base.OnDetachingFrom(dataForm);
           
            if (dataForm != null)
            {
                dataForm.GenerateDataFormItem -= this.OnGenerateDataFormItem;
            }
        }
    }
}