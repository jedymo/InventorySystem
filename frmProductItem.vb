Public Class frmProductItem
    Property id = -1

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim code = txtItemCode.Text
            Dim name = txtName.Text
            Dim description = txtDescription.Text
            Dim quantity = Convert.ToInt32(lblQuantity.Text)
            Dim price = Convert.ToDouble(txtPrice.Text)
            Dim categoryId = cmbCategory.SelectedValue

            Dim ad = New inventoryDataSetTableAdapters.productsTableAdapter


            If id = -1 Then
                ad.Insert(code, name, description, quantity, price, categoryId, Nothing)
            Else
                ad.GetData.EndLoadData()
                Dim row = ad.GetData.FindByid(id)

                row.name = name
                row.description = description
                row.code = code
                row.price = price
                row.category_id = categoryId
                ad.Update(row)
            End If
            MessageBox.Show("Product saved!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub frmProductItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDataSet.categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.InventoryDataSet.categories)


        'If id = -1 Then
        '    Return
        'End If

        'Try

        '    Dim ad = New inventoryDataSetTableAdapters.productsTableAdapter
        '    Dim product = ad.GetData.FindByid(id)

        '    txtItemCode.Text = If(Not product.IscodeNull, product.code, "")
        '    txtName.Text = If(Not product.IsnameNull, product.name, "")
        '    txtDescription.Text = If(Not product.IsdescriptionNull, product.description, "")
        '    txtPrice.Text = If(Not product.IspriceNull, product.price, "")
        '    cmbCategory.SelectedValue = If(Not product.Iscategory_idNull, product.category_id, Nothing)
        '    lblQuantity.Text = If(Not product.IsquantityNull, product.quantity, "0")

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'End Try

    End Sub




End Class