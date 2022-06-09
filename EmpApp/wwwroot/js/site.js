function confirmDelete(uniquId, isDeleteClicked)
{
    var deleteSpan = 'deleteSpan_' + uniquId;
    var confirmDeleteSpan = 'confirmDeletespan_' + uniquId;
    if (isDeleteClicked)
    {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    }
    else
    {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}
