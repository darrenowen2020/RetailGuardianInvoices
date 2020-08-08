CREATE VIEW [dbo].[InvoiceView]
	AS SELECT
		inv.Id as InvoiceId,
		inv.Date as InvoiceDate,
		Supplier.Name as SupplierName,
		Site.SiteName as SiteName,
		inv.InvoiceReference as InvoiceReference,
		inv.Description as InvoiceDescription,
		inv.GrossAmount as InvoiceGross,
		inv.VATAmount as InvoiceVAT,
		inv.NetAmount as InvoiceNet,
		PaymentType.Type as InvoicePaymentType,
		PaymentType.Description as InvoicePaymentDescription,
		inv.Paid as InvoicePaid,
		inv.CreatedDate as InvoiceCreatedDate,
		inv.EditDate as InvoiceEditDate,
		inv.PeriodNo as InvoicePeriod,
		Period.YearNo as PeriodYearNo,
		InvoiceHeading.Description as InvoiceHeading,
		inv.Heading as InvoiceHeadingId,
		inv.PaymentTypeID as InvoicePaymentId,
		inv.SupplierID as InvoiceSupplierId,
		inv.SiteID as InvoiceSiteId,
		inv.Notes as InvoiceNotes,
		PaymentType.ReconcileFlag as InvoicePaymentReconcile,
		inv.CompanyID as InvoiceCompanyId,
		inv.PeriodId as InvoicePeriodId
	 FROM dbo.Invoice inv,
		dbo.Supplier,
		dbo.Site,
		dbo.PaymentType,
		dbo.Period,
		dbo.InvoiceHeading
	where
		dbo.Supplier.Id = inv.SupplierID and
		dbo.Site.Id = inv.SiteID and
		dbo.PaymentType.Id = inv.PaymentTypeID and
		dbo.Period.PeriodKey = inv.PeriodNo and
		dbo.InvoiceHeading.Id = inv.Heading;