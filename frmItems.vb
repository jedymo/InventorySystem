Public Class frmItems

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDataSet.view_detailed_products' table. You can move, or remove it, as needed.
        Me.View_detailed_productsTableAdapter.Fill(Me.InventoryDataSet.view_detailed_products)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmProductItem.ShowDialog()
        frmProductItem.Dispose()
        Me.frmProducts_Load(sender, e)
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        Dim row = GetCurrentGridViewRow()

        Dim productId As Integer = row.Cells(0).Value 'id

        Dim da = Me.ProductsTableAdapter1
        Dim product = da.GetData.FindByid(productId)

        With frmProductItem
            .id = productId
            .txtItemCode.Text = If(Not product.IscodeNull, product.code, "")
            .txtName.Text = If(Not product.IsnameNull, product.name, "")
            .txtDescription.Text = If(Not product.IsdescriptionNull, product.description, "")
            .txtPrice.Text = If(Not product.IspriceNull, product.price, "")
            .cmbCategory.SelectedValue = If(Not product.Iscategory_idNull, product.category_id, Nothing)
            .lblQuantity.Text = If(Not product.IsquantityNull, product.quantity, "0")

            .ShowDialog()
            .Dispose()
        End With
        Me.frmProducts_Load(sender, e)
    End Sub

    Function GetCurrentGridViewRow() As DataGridViewRow
        Dim rowIndex = dgvProducts.CurrentCell.RowIndex
        Return dgvProducts.Rows(rowIndex)
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim cell = dgvProducts.SelectedCells(0)
        Dim row = dgvProducts.Rows(cell.RowIndex)
        Dim productId = row.Cells(0).Value
        Dim da = Me.ProductsTableAdapter1
        Dim product = da.GetData.FindByid(productId)
        product.Delete()
        da.Update(product)

        Me.frmProducts_Load(sender, e)
    End Sub

End Class