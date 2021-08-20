using BlazorApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class FormService
{
    #region Private members
    private FormDbContext dbContext;
    #endregion

    #region Constructor
    public FormService(FormDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion
    /// <summary>
    /// This method add a new product to the DbContext and saves it
    /// </summary>
    /// <param name="form"></param>
    /// <returns></returns>
    public async Task<Form> AddFormAsync(Form form)
    {
        try
        {
            dbContext.forms.Add(form);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return form;
    }

}

