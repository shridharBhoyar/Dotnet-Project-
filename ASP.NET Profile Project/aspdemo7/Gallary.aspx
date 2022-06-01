<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Gallary.aspx.cs" Inherits="aspdemo7.Gallary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



      <!-- ======= Portfolio Section ======= -->
    <div id="portfolio" class="paddsection">

      <div class="container">
        <div class="section-title text-center">
          <h2>My Gallery</h2>
        </div>
      </div>

      <div class="container">

        <div class="row">
          <div class="col-lg-12 d-flex justify-content-center">
            <%--<ul id="portfolio-flters">
              <li data-filter="*" class="filter-active">All</li>
              <li data-filter=".filter-app">App</li>
              <li data-filter=".filter-card">Card</li>
              <li data-filter=".filter-web">Web</li>
            </ul>--%>
          </div>
        </div>

        <div class="row portfolio-container">

          <div class="col-lg-4 col-md-6 portfolio-item filter-app">
            <img src="assets/img/portfolio/polish_station.jfif" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>College</h4>
              <p>Saoner</p>
             </div>
          </div>

          <div class="col-lg-4 col-md-6 portfolio-item filter-web">
            <img src="assets/img/portfolio/park2.jfif" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>Eco Park </h4>
              <p>Saoner</p>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 portfolio-item filter-app " >
            <img src="assets/img/portfolio/lake.jfif" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>Ramtak Lake</h4>
              <p>Ramtek</p>
             </div>
          </div>

          <div class="col-lg-4 col-md-6 portfolio-item filter-card">
            <img src="assets/img/portfolio/workshop_grp.jpg" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>APS Mirotech Workshop</h4>
              <p>Chindwara </p>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 portfolio-item filter-web">
            <img src="assets/img/portfolio/teacher.jpg" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>College Math&Computer Fundamental Teacher </h4>
              <p>Saoner</p>
            </div>
          </div>



          <div class="col-lg-4 col-md-6 portfolio-item filter-app">
            <img src="assets/img/portfolio/niit_chindwara.png" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>NIIT Campuse</h4>
              <p>Chindwara </p>
            </div>
          </div>


              <div class="col-lg-4 col-md-6 portfolio-item filter-web">
            <img src="assets/img/portfolio/workshop.jpg" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>APS Mirotech Workshop</h4>
              <p>Chindwara </p>
             </div>
          </div>

          <div class="col-lg-4 col-md-6 portfolio-item filter-app " >
            <img src="assets/img/portfolio/saoner.jpg" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>Summer in College</h4>
              <p>Saoner</p>
              </div>
          </div>

          <div class="col-lg-4 col-md-6 portfolio-item filter-card">
            <img src="assets/img/portfolio/group_pic_boys.jpg" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>College Function</h4>
              <p>Saoner</p>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 portfolio-item filter-web">
            <img src="assets/img/portfolio/freshar_parttty.png" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>College Function</h4>
              <p>Saoner</p>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 portfolio-item filter-app">
            <img src="assets/img/portfolio/manish_r.jfif" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>Class</h4>
              <p>Saoner</p>
             </div>
          </div>


            <div class="col-lg-4 col-md-6 portfolio-item filter-app">
            <img src="assets/img/portfolio/park.jfif" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>Park</h4>
              <p>Saoner</p>
             </div>
          </div>


             <div class="col-lg-4 col-md-6 portfolio-item filter-web">
            <img src="assets/img/portfolio/adasa_temp.jpg" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>Adasa Temple</h4>
              <p>Adasa</p>
              </div>
          </div>

          <div class="col-lg-4 col-md-6 portfolio-item filter-app">
            <img src="assets/img/portfolio/workshop.jfif" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>APS Mirotech Workshop</h4>
              <p>chindwara</p>
            </div>
          </div>


            <div class="col-lg-4 col-md-6 portfolio-item filter-app">
            <img src="assets/img/portfolio/ramtek.jpg" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>Ram Temple</h4>
              <p>Ramtak</p>
              </div>
          </div>




            
             <div class="col-lg-4 col-md-6 portfolio-item filter-web">
            <img src="assets/img/portfolio/shivay.jfif" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>Ramrama waterfall</h4>
              <p>MP</p>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 portfolio-item filter-app">
            <img src="assets/img/portfolio/shri1.jpg" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>college Bus</h4>
              <p>Saoner</p>
               </div>
          </div>


            <div class="col-lg-4 col-md-6 portfolio-item filter-app">
            <img src="assets/img/portfolio/rohit.jfif" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>Wedding</h4>
              <p>Borujwada </p>
               </div>
          </div>




            
             <div class="col-lg-4 col-md-6 portfolio-item filter-web">
            <img src="assets/img/portfolio/sagar.jpg" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>College Break</h4>
              <p>Saoner</p>
              </div>
          </div>

          <div class="col-lg-4 col-md-6 portfolio-item filter-app">
            <img src="assets/img/portfolio/clg_grp1.jpg" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>College Function</h4>
              <p>Saoner</p>
              </div>
          </div>


            <div class="col-lg-4 col-md-6 portfolio-item filter-app">
            <img src="assets/img/portfolio/travel.jpg" class="img-fluid" alt="">
            <div class="portfolio-info">
              <h4>Ramrama waterfall</h4>
              <p>MP</p>
            </div>
          </div>



        </div>

      </div>

    </div><!-- End Portfolio Section -->






    
      



</asp:Content>
