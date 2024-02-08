terraform {
  cloud {
    organization = "MysteryMystery123"

    workspaces {
      name = "Production"
    }
  }

  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "=3.9.0"
    }
  }
}

provider "azurerm" {
  features {}

  subscription_id = var.subscription_id
  tenant_id       = var.tenant_id
  client_id       = var.client_id
  use_oidc        = true
}