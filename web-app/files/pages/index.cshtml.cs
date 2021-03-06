@page "{name}"
@model DetailsModel
@{
  ViewData["Title"] = "Details";
}

<div id="top-container" class="text-center">
  
  <h2 class="font-weight-bold">@Foods.Name </h1>
 
  <img id="big-food-icon" src = @Model.CurrentFood.ImageSrc >
  ]
  <p id="display-price" class="font-weight-bold text-left">$@String.Format("{0:0.00} / lb", 0)@Model.CurrentFood.Price</p>
</div>

<hr />

<div id="description-container">
  
  <p>@Model.CurrentFood.Desc </p>
</div>

<hr />

<div id="pricing-container" class="d-flex font-weight-bold">
  
  <span id="unit-price" class="d-none">@Model.CurrentFood.Price</span>

  <div class="col text-left">
  <label for="quantity">Quantity:</label>
  <input type="number" id="quantity" name="quantity" min="1">
  </div>

  <div class="col text-right">
  Total: $<span id="total-price">0.00</span>
  </div>

</div>

<hr />

<div id="back-button-container" class="text-center">

  <a class="btn text-white">
  <img style="width: 1.5rem; display: inline;" src="https://content.codecademy.com/courses/asp-dot-net/food_icons/left-arrow.png" />
  Back to home
  </a>
</div>
