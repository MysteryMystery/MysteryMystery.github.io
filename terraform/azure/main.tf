resource "azurerm_resource_group" "portfolio" {
  name     = "rg-portfolio-${var.environment}-${var.region}"
  location = var.region
}

resource "azurerm_static_site" "portfolio" {
  name                = "app-portfolio-${var.environment}-${var.region}"
  resource_group_name = azurerm_resource_group.portfolio.name
  location            = azurerm_resource_group.portfolio.location
  sku_tier            = "Free"
  sku_size            = "Free"
}