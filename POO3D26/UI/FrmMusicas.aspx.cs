using POO3D26.BLL;
using POO3D26.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POO3D26.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TBL_MusicaBLL bllMusica = new TBL_MusicaBLL();
        TBL_MusicaDTO dtoMusica = new TBL_MusicaDTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                this.ExibirGrid();
            }
        }
        private void ExibirGrid()
        {
            GridMusicas.DataSource = bllMusica.ListarMusicas();
            GridMusicas.DataBind();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtNomeAutor.Text = "";
            txtIdGravadora.Text = "";
            txtIdCD.Text = "";
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                dtoMusica.Nome = txtNome.Text;
                dtoMusica.NomeAutor = txtNomeAutor.Text;
                dtoMusica.IdGravadora = int.Parse(txtIdGravadora.Text);
                dtoMusica.IdCD = int.Parse(txtIdCD.Text);

                bllMusica.AdicionarMusica(dtoMusica);
                lblError.Visible = false;
                this.LimparCampos();
                this.ExibirGrid();
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string busca = txtBuscar.Text;
                GridMusicas.DataSource = bllMusica.PesquisarMusica(busca);
                GridMusicas.DataBind();
            }
            catch(Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }
                
        protected void GridMusicas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                dtoMusica.IdMusica = int.Parse(e.NewValues[0].ToString());
                dtoMusica.Nome = e.NewValues[1].ToString();
                dtoMusica.NomeAutor = e.NewValues[2].ToString();
                dtoMusica.IdGravadora = int.Parse(e.NewValues[3].ToString());
                dtoMusica.IdCD = int.Parse(e.NewValues[4].ToString());
                bllMusica.AlterarMusica(dtoMusica);
                GridMusicas.EditIndex = -1;
                this.ExibirGrid();
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }            
        }
        protected void GridMusicas_RowDeleting(object sender, GridViewDeleteEventArgs Registro)
        {
            try
            {
                dtoMusica.IdMusica = Convert.ToInt32(Registro.Values[0]);
                bllMusica.DeletarMusica(dtoMusica);
                this.ExibirGrid();
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }

        protected void GridMusicas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridMusicas.EditIndex = e.NewEditIndex;
            this.ExibirGrid();
        }

        protected void GridMusicas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridMusicas.EditIndex = -1;
            this.ExibirGrid();
        }

        protected void GridMusicas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridMusicas.PageIndex = e.NewPageIndex;
            this.ExibirGrid();
        }

    }

}